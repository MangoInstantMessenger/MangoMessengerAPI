using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions;

public class LoginCommandHandler : IRequestHandler<LoginCommand, Result<TokensResponse>>
{
    private readonly IJwtGenerator jwtGenerator;
    private readonly MangoDbContext dbContext;
    private readonly ISignInManagerService signInManager;
    private readonly ResponseFactory<TokensResponse> responseFactory;
    private readonly IJwtGeneratorSettings jwtGeneratorSettings;
    private readonly IBlobServiceSettings blobServiceSettings;

    public LoginCommandHandler(
        ISignInManagerService signInManager,
        IJwtGenerator jwtGenerator,
        MangoDbContext dbContext,
        ResponseFactory<TokensResponse> responseFactory,
        IJwtGeneratorSettings jwtGeneratorSettings,
        IBlobServiceSettings blobServiceSettings)
    {
        this.signInManager = signInManager;
        this.jwtGenerator = jwtGenerator;
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
        this.jwtGeneratorSettings = jwtGeneratorSettings;
        this.blobServiceSettings = blobServiceSettings;
    }

    public async Task<Result<TokensResponse>> Handle(
        LoginCommand request,
        CancellationToken cancellationToken)
    {
        var user = await dbContext.Users
            .FirstOrDefaultAsync(
                userEntity => userEntity.Email == request.Email,
                cancellationToken);

        if (user is null)
        {
            const string errorMessage = ResponseMessageCodes.InvalidCredentials;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }

        var result = await signInManager.CheckPasswordSignInAsync(user, request.Password, false);

        if (!result.Succeeded)
        {
            const string errorMessage = ResponseMessageCodes.InvalidCredentials;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }

        var session = new SessionEntity
        {
            UserId = user.Id,
            RefreshToken = Guid.NewGuid(),
            ExpiresAt = DateTime.UtcNow.AddDays(jwtGeneratorSettings.MangoRefreshTokenLifetimeDays),
            CreatedAt = DateTime.UtcNow,
        };

        var accessToken = jwtGenerator.GenerateJwtToken(user);

        var userSessions = dbContext.Sessions
            .Where(entity => entity.UserId == user.Id);

        var userSessionsCount = await userSessions.CountAsync(cancellationToken);

        if (userSessionsCount >= 5)
        {
            dbContext.Sessions.RemoveRange(userSessions);
        }

        _ = dbContext.Sessions.Add(session);
        _ = await dbContext.SaveChangesAsync(cancellationToken);

        var expires = ((DateTimeOffset)session.ExpiresAt).ToUnixTimeSeconds();
        var userDisplayName = user.DisplayName;
        var userProfilePictureUrl = $"{blobServiceSettings.MangoBlobAccess}/{user.Image}";

        var tokens = TokensResponse.FromSuccess(
            accessToken,
            session.RefreshToken,
            user.Id,
            expires,
            userDisplayName,
            userProfilePictureUrl,
            user.DisplayNameColour);

        return responseFactory.SuccessResponse(tokens);
    }
}

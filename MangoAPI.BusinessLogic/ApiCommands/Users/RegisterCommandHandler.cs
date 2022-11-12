using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, Result<TokensResponse>>
{
    private readonly MangoDbContext dbContext;
    private readonly IUserManagerService userManager;
    private readonly ResponseFactory<TokensResponse> responseFactory;
    private readonly IJwtGenerator jwtGenerator;
    private readonly IJwtGeneratorSettings jwtGeneratorSettings;
    private readonly IBlobServiceSettings blobServiceSettings;

    public RegisterCommandHandler(
        IUserManagerService userManager,
        MangoDbContext dbContext,
        IJwtGenerator jwtGenerator,
        IJwtGeneratorSettings jwtGeneratorSettings,
        ResponseFactory<TokensResponse> responseFactory,
        IBlobServiceSettings blobServiceSettings)
    {
        this.userManager = userManager;
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
        this.jwtGenerator = jwtGenerator;
        this.jwtGeneratorSettings = jwtGeneratorSettings;
        this.blobServiceSettings = blobServiceSettings;
    }

    public async Task<Result<TokensResponse>> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        var userExists = await dbContext.Users
            .AnyAsync(entity => entity.Email == request.Email, cancellationToken);

        if (userExists)
        {
            const string errorMessage = ResponseMessageCodes.UserAlreadyExists;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }

        var color = new Random().Next(11);

        var newUser = new UserEntity
        {
            DisplayName = request.DisplayName,
            UserName = Guid.NewGuid().ToString(),
            Email = request.Email,
            EmailCode = Guid.NewGuid(),
            Image = "default_avatar.png",
            EmailConfirmed = true,
            DisplayNameColour = (DisplayNameColour)color,
        };

        await userManager.CreateAsync(newUser, request.Password);

        var userInfo = new UserInformationEntity
        {
            UserId = newUser.Id,
            CreatedAt = DateTime.UtcNow,
        };

        dbContext.UserInformation.Add(userInfo);

        var session = new SessionEntity
        {
            UserId = newUser.Id,
            RefreshToken = Guid.NewGuid(),
            ExpiresAt = DateTime.UtcNow.AddDays(jwtGeneratorSettings.MangoRefreshTokenLifetimeDays),
            CreatedAt = DateTime.UtcNow,
        };

        var accessToken = jwtGenerator.GenerateJwtToken(newUser);

        dbContext.Sessions.Add(session);

        await dbContext.SaveChangesAsync(cancellationToken);

        var expires = ((DateTimeOffset)session.ExpiresAt).ToUnixTimeSeconds();
        var userDisplayName = newUser.DisplayName;
        var userProfilePictureUrl = $"{blobServiceSettings.MangoBlobAccess}/{newUser.Image}";

        var response = TokensResponse.FromSuccess(
            accessToken,
            session.RefreshToken,
            newUser.Id,
            expires,
            userDisplayName,
            userProfilePictureUrl,
            newUser.DisplayNameColour);
        var result = responseFactory.SuccessResponse(response);

        return result;
    }
}

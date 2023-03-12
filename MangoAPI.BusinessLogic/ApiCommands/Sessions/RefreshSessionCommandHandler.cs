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

public class RefreshSessionCommandHandler : IRequestHandler<RefreshSessionCommand, Result<TokensResponse>>
{
    private readonly IJwtGenerator jwtGenerator;
    private readonly MangoDbContext dbContext;
    private readonly ResponseFactory<TokensResponse> responseFactory;
    private readonly IJwtGeneratorSettings jwtGeneratorSettings;
    private readonly IBlobServiceSettings blobServiceSettings;

    public RefreshSessionCommandHandler(
        MangoDbContext dbContext,
        IJwtGenerator jwtGenerator,
        ResponseFactory<TokensResponse> responseFactory,
        IJwtGeneratorSettings jwtGeneratorSettings,
        IBlobServiceSettings blobServiceSettings)
    {
        this.dbContext = dbContext;
        this.jwtGenerator = jwtGenerator;
        this.responseFactory = responseFactory;
        this.jwtGeneratorSettings = jwtGeneratorSettings;
        this.blobServiceSettings = blobServiceSettings;
    }

    public async Task<Result<TokensResponse>> Handle(
        RefreshSessionCommand request,
        CancellationToken cancellationToken)
    {
        var session = await dbContext.Sessions
            .Include(x => x.UserEntity)
            .FirstOrDefaultAsync(
                entity => entity.Id == request.RefreshToken,
                cancellationToken);

        if (session is null || session.IsExpired)
        {
            const string errorMessage = ResponseMessageCodes.InvalidOrExpiredRefreshToken;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }

        var userSessions = dbContext.Sessions
            .Where(x => x.UserId == session.UserId);

        var userSessionCount = await userSessions.CountAsync(cancellationToken);

        switch (userSessionCount)
        {
            case >= 5:
                dbContext.Sessions.RemoveRange(userSessions);
                break;
            default:
                dbContext.Sessions.Remove(session);
                break;
        }

        var newSession = new SessionEntity
        {
            Id = Guid.NewGuid(),
            UserId = session.UserId,
            ExpiresAt = DateTime.UtcNow.AddDays(jwtGeneratorSettings.MangoRefreshTokenLifetimeDays),
            CreatedAt = DateTime.UtcNow,
        };

        var accessToken = jwtGenerator.GenerateJwtToken(session.UserEntity);

        dbContext.Sessions.Add(newSession);
        await dbContext.SaveChangesAsync(cancellationToken);

        var expires = ((DateTimeOffset)session.ExpiresAt).ToUnixTimeSeconds();
        var userDisplayName = session.UserEntity.DisplayName;
        var userProfilePictureUrl = $"{blobServiceSettings.MangoBlobAccess}/{session.UserEntity.ImageFileName}";

        var result = TokensResponse.FromSuccess(
            accessToken,
            newSession.Id,
            session.UserId,
            expires,
            userDisplayName,
            userProfilePictureUrl,
            session.UserEntity.DisplayNameColour);

        return responseFactory.SuccessResponse(result);
    }
}
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

    public RefreshSessionCommandHandler(
        MangoDbContext dbContext,
        IJwtGenerator jwtGenerator,
        ResponseFactory<TokensResponse> responseFactory,
        IJwtGeneratorSettings jwtGeneratorSettings)
    {
        this.dbContext = dbContext;
        this.jwtGenerator = jwtGenerator;
        this.responseFactory = responseFactory;
        this.jwtGeneratorSettings = jwtGeneratorSettings;
    }

    public async Task<Result<TokensResponse>> Handle(RefreshSessionCommand request,
        CancellationToken cancellationToken)
    {
        var session = await dbContext.Sessions
            .Include(x => x.UserEntity)
            .FirstOrDefaultAsync(entity => entity.RefreshToken == request.RefreshToken,
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
            RefreshToken = Guid.NewGuid(),
            UserId = session.UserId,
            ExpiresAt = DateTime.UtcNow.AddDays(jwtGeneratorSettings.MangoRefreshTokenLifetimeDays),
            CreatedAt = DateTime.UtcNow,
        };

        var jwtToken = jwtGenerator.GenerateJwtToken(session.UserEntity);

        dbContext.Sessions.Add(newSession);
        await dbContext.SaveChangesAsync(cancellationToken);

        var expires = ((DateTimeOffset)session.ExpiresAt).ToUnixTimeSeconds();

        return responseFactory.SuccessResponse(TokensResponse.FromSuccess(jwtToken, newSession.RefreshToken,
            session.UserId, expires));
    }
}

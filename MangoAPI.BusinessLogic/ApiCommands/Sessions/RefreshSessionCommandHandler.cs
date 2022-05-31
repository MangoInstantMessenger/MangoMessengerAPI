using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions;

public class RefreshSessionCommandHandler : IRequestHandler<RefreshSessionCommand, Result<TokensResponse>>
{
    private readonly IJwtGenerator _jwtGenerator;
    private readonly MangoDbContext _dbContext;
    private readonly ResponseFactory<TokensResponse> _responseFactory;
    private readonly IJwtGeneratorSettings _jwtGeneratorSettings;

    public RefreshSessionCommandHandler(
        MangoDbContext dbContext,
        IJwtGenerator jwtGenerator,
        ResponseFactory<TokensResponse> responseFactory,
        IJwtGeneratorSettings jwtGeneratorSettings)
    {
        _dbContext = dbContext;
        _jwtGenerator = jwtGenerator;
        _responseFactory = responseFactory;
        _jwtGeneratorSettings = jwtGeneratorSettings;
    }

    public async Task<Result<TokensResponse>> Handle(RefreshSessionCommand request,
        CancellationToken cancellationToken)
    {
        var session = await _dbContext.Sessions
            .FirstOrDefaultAsync(entity => entity.RefreshToken == request.RefreshToken,
                cancellationToken);

        if (session is null || session.IsExpired)
        {
            const string errorMessage = ResponseMessageCodes.InvalidOrExpiredRefreshToken;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, details);
        }

        var userSessions = _dbContext.Sessions
            .Where(x => x.UserId == session.UserId);

        var userSessionCount = await userSessions.CountAsync(cancellationToken);

        switch (userSessionCount)
        {
            case >= 5:
                _dbContext.Sessions.RemoveRange(userSessions);
                break;
            default:
                _dbContext.Sessions.Remove(session);
                break;
        }

        var newSession = new SessionEntity
        {
            RefreshToken = Guid.NewGuid(),
            UserId = session.UserId,
            ExpiresAt = DateTime.UtcNow.AddDays(_jwtGeneratorSettings.MangoRefreshTokenLifetime),
            CreatedAt = DateTime.UtcNow,
        };

        var jwtToken = _jwtGenerator.GenerateJwtToken(session.UserId);

        _dbContext.Sessions.Add(newSession);
        await _dbContext.SaveChangesAsync(cancellationToken);

        var expires = ((DateTimeOffset) session.ExpiresAt).ToUnixTimeSeconds();

        return _responseFactory.SuccessResponse(TokensResponse.FromSuccess(jwtToken, newSession.RefreshToken,
            session.UserId, expires));
    }
}
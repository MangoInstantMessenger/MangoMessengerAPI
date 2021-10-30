using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public class RefreshSessionCommandHandler : IRequestHandler<RefreshSessionCommand, Result<TokensResponse>>
    {
        private readonly IJwtGenerator _jwtGenerator;
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly ResponseFactory<TokensResponse> _responseFactory;

        public RefreshSessionCommandHandler(MangoPostgresDbContext postgresDbContext, IJwtGenerator jwtGenerator,
            ResponseFactory<TokensResponse> responseFactory)
        {
            _postgresDbContext = postgresDbContext;
            _jwtGenerator = jwtGenerator;
            _responseFactory = responseFactory;
        }

        public async Task<Result<TokensResponse>> Handle(RefreshSessionCommand request, CancellationToken cancellationToken)
        {
            var session = await _postgresDbContext.Sessions.GetSessionByRefreshTokenAsync(request.RefreshToken,
                    cancellationToken);

            if (session is null || session.IsExpired)
            {
                const string errorMessage = ResponseMessageCodes.InvalidOrExpiredRefreshToken;
                var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, details);
            }

            var userSessions = _postgresDbContext.Sessions
                .Where(x => x.UserId == session.UserId);

            var userSessionCount = await userSessions.CountAsync(cancellationToken);

            switch (userSessionCount)
            {
                case >= 5:
                    _postgresDbContext.Sessions.RemoveRange(userSessions);
                    break;
                default:
                    _postgresDbContext.Sessions.Remove(session);
                    break;
            }

            var refreshLifetime = EnvironmentConstants.RefreshTokenLifeTime;

            if (refreshLifetime == null || !int.TryParse(refreshLifetime, out var refreshLifetimeParsed))
            {
                const string errorMessage = ResponseMessageCodes.RefreshTokenLifeTimeError;
                var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, details);
            }

            var newSession = new SessionEntity
            {
                RefreshToken = Guid.NewGuid(),
                UserId = session.UserId,
                ExpiresAt = DateTime.UtcNow.AddDays(refreshLifetimeParsed),
                CreatedAt = DateTime.UtcNow,
            };

            var rolesQuery = from userRole in _postgresDbContext.UserRoles.AsNoTracking()
                             join role in _postgresDbContext.Roles on userRole.RoleId equals role.Id
                             where userRole.UserId == session.UserId
                             select role.Name;

            var roles = await rolesQuery.ToListAsync(cancellationToken);

            var jwtToken = _jwtGenerator.GenerateJwtToken(session.UserId, roles);

            _postgresDbContext.Sessions.Add(newSession);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            var expires = ((DateTimeOffset)session.ExpiresAt).ToUnixTimeSeconds();

            return _responseFactory.SuccessResponse(TokensResponse.FromSuccess(jwtToken, newSession.RefreshToken,
                session.UserId, expires));
        }
    }
}
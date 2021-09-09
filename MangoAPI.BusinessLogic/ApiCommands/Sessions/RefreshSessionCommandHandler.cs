using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public class RefreshSessionCommandHandler : IRequestHandler<RefreshSessionCommand, TokensResponse>
    {
        private readonly IJwtGenerator _jwtGenerator;
        private readonly MangoPostgresDbContext _postgresDbContext;

        public RefreshSessionCommandHandler(MangoPostgresDbContext postgresDbContext, IJwtGenerator jwtGenerator)
        {
            _postgresDbContext = postgresDbContext;
            _jwtGenerator = jwtGenerator;
        }

        public async Task<TokensResponse> Handle(RefreshSessionCommand request, CancellationToken cancellationToken)
        {
            var session =
                await _postgresDbContext.Sessions.GetSessionByRefreshTokenAsync(request.RefreshToken,
                    cancellationToken);

            if (session is null || session.IsExpired)
            {
                throw new BusinessException(ResponseMessageCodes.InvalidOrExpiredRefreshToken);
            }

            var user = await _postgresDbContext.Users.FindUserByIdAsync(session.UserId, cancellationToken);

            var userSessions = _postgresDbContext.Sessions
                .Where(x => x.UserId == user.Id);

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
                throw new BusinessException(ResponseMessageCodes.RefreshTokenLifeTimeError);
            }

            var newSession = new SessionEntity
            {
                RefreshToken = Guid.NewGuid(),
                UserId = user.Id,
                ExpiresAt = DateTime.UtcNow.AddDays(refreshLifetimeParsed),
                CreatedAt = DateTime.UtcNow,
            };

            var roleIds = await _postgresDbContext.UserRoles
                .Where(x => x.UserId == user.Id)
                .Select(x => x.RoleId)
                .ToListAsync(cancellationToken);

            var roles = await _postgresDbContext.Roles
                .Where(x => roleIds.Contains(x.Id))
                .Select(x => x.Name)
                .ToListAsync(cancellationToken);

            var jwtToken = _jwtGenerator.GenerateJwtToken(user, roles);

            await _postgresDbContext.Sessions.AddAsync(newSession, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return TokensResponse.FromSuccess(jwtToken, newSession.RefreshToken);
        }
    }
}
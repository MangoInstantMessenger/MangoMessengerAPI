using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public class RefreshSessionCommandHandler : IRequestHandler<RefreshSessionCommand, RefreshSessionResponse>
    {
        private readonly IJwtGenerator _jwtGenerator;
        private readonly MangoPostgresDbContext _postgresDbContext;

        public RefreshSessionCommandHandler(MangoPostgresDbContext postgresDbContext, IJwtGenerator jwtGenerator)
        {
            _postgresDbContext = postgresDbContext;
            _jwtGenerator = jwtGenerator;
        }

        public async Task<RefreshSessionResponse> Handle(RefreshSessionCommand request,
            CancellationToken cancellationToken)
        {
            var session = await _postgresDbContext.Sessions
                .FirstOrDefaultAsync(x => x.RefreshToken == request.RefreshToken,
                    cancellationToken);

            if (session is null || session.IsExpired)
            {
                throw new BusinessException(ResponseMessageCodes.InvalidOrExpiredRefreshToken);
            }

            var user = await _postgresDbContext.Users.FirstOrDefaultAsync(x => x.Id == session.Id,
                cancellationToken);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var userSessions = _postgresDbContext.Sessions
                .Where(x => x.UserId == user.Id);

            var userSessionCount = await userSessions.CountAsync(cancellationToken);

            if (userSessionCount >= 5)
            {
                _postgresDbContext.Sessions.RemoveRange(userSessions);
            }

            var refreshLifetime = EnvironmentConstants.RefreshTokenLifeTime;

            if (refreshLifetime == null || !int.TryParse(refreshLifetime, out var refreshLifetimeParsed))
            {
                throw new BusinessException(ResponseMessageCodes.RefreshTokenLifeTimeError);
            }

            var newSession = new SessionEntity
            {
                Id = Guid.NewGuid().ToString(),
                RefreshToken = Guid.NewGuid().ToString(),
                UserId = user.Id,
                Expires = DateTime.UtcNow.AddDays(refreshLifetimeParsed),
                Created = DateTime.UtcNow
            };

            var jwtToken = _jwtGenerator.GenerateJwtToken(user, "User");

            await _postgresDbContext.Sessions.AddAsync(newSession, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return RefreshSessionResponse.FromSuccess(jwtToken, newSession.RefreshToken);
        }
    }
}
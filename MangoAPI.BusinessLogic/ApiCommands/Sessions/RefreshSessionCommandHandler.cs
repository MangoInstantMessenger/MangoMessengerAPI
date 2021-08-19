namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
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

    public class RefreshSessionCommandHandler : IRequestHandler<RefreshSessionCommand, RefreshSessionResponse>
    {
        private readonly IJwtGenerator jwtGenerator;
        private readonly MangoPostgresDbContext postgresDbContext;

        public RefreshSessionCommandHandler(MangoPostgresDbContext postgresDbContext, IJwtGenerator jwtGenerator)
        {
            this.postgresDbContext = postgresDbContext;
            this.jwtGenerator = jwtGenerator;
        }

        public async Task<RefreshSessionResponse> Handle(
            RefreshSessionCommand request,
            CancellationToken cancellationToken)
        {
            var session = await postgresDbContext.Sessions
                .FirstOrDefaultAsync(
                    x => x.RefreshToken == request.RefreshToken,
                    cancellationToken);

            if (session is null || session.IsExpired)
            {
                throw new BusinessException(ResponseMessageCodes.InvalidOrExpiredRefreshToken);
            }

            var user = await postgresDbContext.Users.FirstAsync(
                x => x.Id == session.UserId,
                cancellationToken);

            var userSessions = postgresDbContext.Sessions
                .Where(x => x.UserId == user.Id);

            var userSessionCount = await userSessions.CountAsync(cancellationToken);

            switch (userSessionCount)
            {
                case >= 5:
                    postgresDbContext.Sessions.RemoveRange(userSessions);
                    break;
                default:
                    postgresDbContext.Sessions.Remove(session);
                    break;
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
                Created = DateTime.UtcNow,
            };

            var roleIds = await postgresDbContext.UserRoles
                .Where(x => x.UserId == user.Id)
                .Select(x => x.RoleId)
                .ToListAsync(cancellationToken);

            var roles = await postgresDbContext.Roles
                .Where(x => roleIds.Contains(x.Id))
                .Select(x => x.Name)
                .ToListAsync(cancellationToken);

            var jwtToken = jwtGenerator.GenerateJwtToken(user, roles);

            await postgresDbContext.Sessions.AddAsync(newSession, cancellationToken);
            await postgresDbContext.SaveChangesAsync(cancellationToken);

            return RefreshSessionResponse.FromSuccess(jwtToken, newSession.RefreshToken);
        }
    }
}

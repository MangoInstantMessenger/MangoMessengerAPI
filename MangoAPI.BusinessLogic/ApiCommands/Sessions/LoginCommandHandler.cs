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
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginResponse>
    {
        private readonly IJwtGenerator jwtGenerator;
        private readonly MangoPostgresDbContext postgresDbContext;
        private readonly SignInManager<UserEntity> signInManager;

        public LoginCommandHandler(SignInManager<UserEntity> signInManager, IJwtGenerator jwtGenerator,
            MangoPostgresDbContext postgresDbContext)
        {
            this.signInManager = signInManager;
            this.jwtGenerator = jwtGenerator;
            this.postgresDbContext = postgresDbContext;
        }

        public async Task<LoginResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await postgresDbContext.Users
                .FirstOrDefaultAsync(x => x.Email == request.Email,
                    cancellationToken);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.InvalidCredentials);
            }

            var result = await signInManager.CheckPasswordSignInAsync(user, request.Password, false);

            if (!result.Succeeded)
            {
                throw new BusinessException(ResponseMessageCodes.InvalidCredentials);
            }

            var refreshLifetime = EnvironmentConstants.RefreshTokenLifeTime;

            if (refreshLifetime == null || !int.TryParse(refreshLifetime, out var refreshLifetimeParsed))
            {
                throw new BusinessException(ResponseMessageCodes.RefreshTokenLifeTimeError);
            }

            var session = new SessionEntity
            {
                Id = Guid.NewGuid().ToString(),
                UserId = user.Id,
                RefreshToken = Guid.NewGuid().ToString(),
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

            var userSessions = postgresDbContext.Sessions
                .Where(x => x.UserId == user.Id);

            var userSessionsCount = await userSessions.CountAsync(cancellationToken);

            if (userSessionsCount >= 5)
            {
                postgresDbContext.Sessions.RemoveRange(userSessions);
            }

            await postgresDbContext.Sessions.AddAsync(session, cancellationToken);
            await postgresDbContext.SaveChangesAsync(cancellationToken);

            return LoginResponse.FromSuccess(jwtToken, session.RefreshToken);
        }
    }
}

using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, TokensResponse>
    {
        private readonly IJwtGenerator _jwtGenerator;
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly SignInManager<UserEntity> _signInManager;

        public LoginCommandHandler(SignInManager<UserEntity> signInManager, IJwtGenerator jwtGenerator,
            MangoPostgresDbContext postgresDbContext)
        {
            _signInManager = signInManager;
            _jwtGenerator = jwtGenerator;
            _postgresDbContext = postgresDbContext;
        }

        public async Task<TokensResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.FindUserByEmailOrPhoneAsync(request.EmailOrPhone, cancellationToken);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.InvalidCredentials);
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);

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

            var userSessions = _postgresDbContext.Sessions.GetUserSessionsById(user.Id);

            var userSessionsCount = await userSessions.CountAsync(cancellationToken);

            if (userSessionsCount >= 5)
            {
                _postgresDbContext.Sessions.RemoveRange(userSessions);
            }

            await _postgresDbContext.Sessions.AddAsync(session, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return TokensResponse.FromSuccess(jwtToken, session.RefreshToken);
        }
    }
}
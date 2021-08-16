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

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginResponse>
    {
        private readonly IJwtGenerator _jwtGenerator;
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly SignInManager<UserEntity> _signInManager;
        private readonly UserManager<UserEntity> _userManager;

        public LoginCommandHandler(UserManager<UserEntity> userManager,
            SignInManager<UserEntity> signInManager,
            IJwtGenerator jwtGenerator,
            MangoPostgresDbContext postgresDbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtGenerator = jwtGenerator;
            _postgresDbContext = postgresDbContext;
        }

        public async Task<LoginResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user is null) throw new BusinessException(ResponseMessageCodes.InvalidCredentials);

            var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);

            if (!result.Succeeded) throw new BusinessException(ResponseMessageCodes.InvalidCredentials);

            if (!user.Verified) throw new BusinessException(ResponseMessageCodes.UserNotVerified);

            var refreshLifetime = EnvironmentConstants.RefreshTokenLifeTime;

            if (refreshLifetime == null || !int.TryParse(refreshLifetime, out var refreshLifetimeParsed))
                throw new BusinessException(ResponseMessageCodes.RefreshTokenLifeTimeError);

            var session = new SessionEntity
            {
                Id = Guid.NewGuid().ToString(),
                RefreshToken = Guid.NewGuid().ToString(),
                Expires = DateTime.UtcNow.AddDays(refreshLifetimeParsed),
                Created = DateTime.UtcNow
            };

            var jwtToken = _jwtGenerator.GenerateJwtToken(user);

            session.UserId = user.Id;

            var userSessions = _postgresDbContext.Sessions
                .Where(x => x.UserId == user.Id);

            var userSessionsCount = await userSessions.CountAsync(cancellationToken);

            if (userSessionsCount >= 5) _postgresDbContext.Sessions.RemoveRange(userSessions);

            await _postgresDbContext.Sessions.AddAsync(session, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return LoginResponse.FromSuccess(jwtToken, session.Id);
        }
    }
}
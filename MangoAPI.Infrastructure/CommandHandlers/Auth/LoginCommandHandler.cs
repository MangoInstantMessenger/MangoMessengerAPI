using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.DTO.Responses.Auth;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.CommandHandlers.Auth
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginResponse>
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly SignInManager<UserEntity> _signInManager;
        private readonly IJwtGenerator _jwtGenerator;
        private readonly MangoPostgresDbContext _postgresDbContext;

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

            if (user is null)
            {
                return LoginResponse.InvalidCredentials;
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);

            if (!result.Succeeded)
            {
                return LoginResponse.InvalidCredentials;
            }

            if (!user.Verified)
            {
                return LoginResponse.UserUnverified;
            }

            var refreshToken = _jwtGenerator.GenerateRefreshToken();

            var jwtToken = _jwtGenerator.GenerateJwtToken(user);

            refreshToken.UserId = user.Id;

            var userRefreshTokens = _postgresDbContext.RefreshTokens
                .Where(x => x.UserId == user.Id);

            var userTokensCount = await userRefreshTokens.CountAsync(cancellationToken);

            if (userTokensCount >= 5)
            {
                _postgresDbContext.RefreshTokens.RemoveRange(userRefreshTokens);
            }

            await _postgresDbContext.RefreshTokens.AddAsync(refreshToken, cancellationToken);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return LoginResponse.FromSuccessWithData(jwtToken, refreshToken.Id);
        }
    }
}
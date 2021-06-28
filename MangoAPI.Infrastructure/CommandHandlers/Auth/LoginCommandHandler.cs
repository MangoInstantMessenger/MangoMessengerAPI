using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.DTO.Responses.Auth;
using MangoAPI.Infrastructure.Database;
using MangoAPI.Infrastructure.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Infrastructure.CommandHandlers.Auth
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginResponse>
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly SignInManager<UserEntity> _signInManager;
        private readonly IJwtGenerator _jwtGenerator;
        private readonly MangoPostgresDbContext _postgresDbContext;

        public LoginCommandHandler(UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager,
            IJwtGenerator jwtGenerator, MangoPostgresDbContext postgresDbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtGenerator = jwtGenerator;
            _postgresDbContext = postgresDbContext;
        }

        //ToDo: Login does not check whether the user has verified the email. I can login unverified.
        public async Task<LoginResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            UserEntity user;

            try
            {
                user = await _userManager.FindByEmailAsync(request.Email);
            }
            catch (Exception)
            {
                return LoginResponse.InvalidEmail;
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);

            if (!result.Succeeded)
                return LoginResponse.InvalidPassword;


            var refreshToken = _jwtGenerator.GenerateRefreshToken(request.UserAgent,
                request.FingerPrint, request.IpAddress);

            var jwtToken = _jwtGenerator.GenerateJwtToken(user);

            refreshToken.UserId = user.Id;

            await _postgresDbContext.RefreshTokens.AddAsync(refreshToken, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return LoginResponse.FromSuccess(jwtToken, refreshToken.Id);
        }
    }
}
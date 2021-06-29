using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Constants;
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
        private readonly IRequestMetadataService _metadataService;
        private readonly IFingerprintService _fingerprintService;
        private readonly ICookieService _cookieService;

        public LoginCommandHandler(UserManager<UserEntity> userManager, 
            SignInManager<UserEntity> signInManager,
            IJwtGenerator jwtGenerator,
            MangoPostgresDbContext postgresDbContext, 
            IRequestMetadataService metadataService,
            IFingerprintService fingerprintService, ICookieService cookieService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtGenerator = jwtGenerator;
            _postgresDbContext = postgresDbContext;
            _metadataService = metadataService;
            _fingerprintService = fingerprintService;
            _cookieService = cookieService;
        }

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

            if (!user.EmailConfirmed)
            {
                return LoginResponse.Unverified;
            }

            var metadata = _metadataService.GetRequestMetadata();
            var refreshToken = _jwtGenerator.GenerateRefreshToken(metadata.UserAgent,
                _fingerprintService.GetFingerprint(metadata), metadata.IpAddress);

            var jwtToken = _jwtGenerator.GenerateJwtToken(user);

            refreshToken.UserId = user.Id;

            var userTokens = _postgresDbContext.RefreshTokens
                .Where(x => x.UserId == user.Id);

            foreach (var token in userTokens)
            {
                token.Revoked = DateTime.Now;
            }

            _postgresDbContext.UpdateRange(userTokens);

            if (await userTokens.CountAsync(cancellationToken) >= 5)
            {
                _postgresDbContext.RefreshTokens.RemoveRange(userTokens);
            }

            await _postgresDbContext.RefreshTokens.AddAsync(refreshToken, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);
            _cookieService.Set(CookieConstants.MangoRefreshTokenId, refreshToken.Id, 7);
            return LoginResponse.FromSuccess(jwtToken, refreshToken.Id);
        }
    }
}
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
        private readonly IRequestMetadataService _metadataService;
        private readonly IFingerprintService _fingerprintService;

        public LoginCommandHandler(UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager,
            IJwtGenerator jwtGenerator, MangoPostgresDbContext postgresDbContext,
            IRequestMetadataService metadataService,
            IFingerprintService fingerprintService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtGenerator = jwtGenerator;
            _postgresDbContext = postgresDbContext;
            _metadataService = metadataService;
            _fingerprintService = fingerprintService;
        }

        public async Task<LoginResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user == null)
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

            var metadata = _metadataService.GetRequestMetadata();

            var browserFingerPrint = _fingerprintService.GetFingerprint(metadata);

            var refreshToken = _jwtGenerator.GenerateRefreshToken(
                metadata.UserAgent,
                browserFingerPrint,
                metadata.IpAddress);

            var jwtToken = _jwtGenerator.GenerateJwtToken(user);

            refreshToken.UserId = user.Id;

            var oldUserTokenSameDevice = await _postgresDbContext.RefreshTokens
                .FirstOrDefaultAsync(x => x.UserId == user.Id && x.BrowserFingerprint == browserFingerPrint,
                    cancellationToken);

            if (oldUserTokenSameDevice != null)
            {
                _postgresDbContext.Remove(oldUserTokenSameDevice);
            }

            await _postgresDbContext.RefreshTokens.AddAsync(refreshToken, cancellationToken);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return LoginResponse.FromSuccessWithData(jwtToken, refreshToken.Id);
        }
    }
}
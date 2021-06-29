using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Constants;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.DTO.Responses.Auth;
using MediatR;

namespace MangoAPI.Infrastructure.CommandHandlers.Auth
{
    public class LogoutCommandHandler : IRequestHandler<LogoutCommand, LogoutResponse>
    {
        private readonly ICookieService _cookieService;
        private readonly IJwtRefreshService _jwtRefreshService;
        private readonly IRequestMetadataService _metadataService;

        public LogoutCommandHandler(ICookieService cookieService, IJwtRefreshService jwtRefreshService, IRequestMetadataService metadataService)
        {
            _cookieService = cookieService;
            _jwtRefreshService = jwtRefreshService;
            _metadataService = metadataService;
        }

        public async Task<LogoutResponse> Handle(LogoutCommand request, CancellationToken cancellationToken)
        {
            var requestMetadata = _metadataService.GetRequestMetadata();
            var refreshTokenId = _cookieService.Get(CookieConstants.MangoRefreshTokenId);
            var validationResult =
                await _jwtRefreshService.VerifyUserRefreshTokenAsync(
                    refreshTokenId,
                    requestMetadata,
                    cancellationToken);

            if (validationResult.IsSuspicious)
                return LogoutResponse.SuspiciousLogout;

            if (!validationResult.Success)
                return LogoutResponse.RefreshTokenNotValidated;

            var res = await _jwtRefreshService.RevokeRefreshTokenAsync(validationResult.RefreshToken.Id, 
                cancellationToken);
            
            if (!res.Success)
                return LogoutResponse.RefreshTokenNotFoundResponse;
            
            _cookieService.Remove(CookieConstants.MangoRefreshTokenId);
            
            return LogoutResponse.SuccessResponse;
        }
    }
}
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

        public LogoutCommandHandler(ICookieService cookieService, IJwtRefreshService jwtRefreshService,
            IRequestMetadataService metadataService)
        {
            _cookieService = cookieService;
            _jwtRefreshService = jwtRefreshService;
            _metadataService = metadataService;
        }

        public async Task<LogoutResponse> Handle(LogoutCommand request, CancellationToken cancellationToken)
        {
            var requestMetadata = _metadataService.GetRequestMetadata();
            var refreshTokenId = _cookieService.Get(CookieConstants.MangoRefreshTokenId);

            var validationResult = await _jwtRefreshService.VerifyUserRefreshTokenAsync(refreshTokenId,
                requestMetadata,
                cancellationToken);

            if (validationResult.IsSuspicious)
            {
                return LogoutResponse.SuspiciousAction;
            }

            if (!validationResult.Success)
            {
                return LogoutResponse.InvalidOrEmptyRefreshToken;
            }

            var result = await _jwtRefreshService.RevokeRefreshTokenAsync(validationResult.RefreshToken.Id,
                cancellationToken);

            if (!result.Success)
            {
                return LogoutResponse.InvalidOrEmptyRefreshToken;
            }

            _cookieService.Remove(CookieConstants.MangoRefreshTokenId);

            return LogoutResponse.SuccessResponse;
        }
    }
}
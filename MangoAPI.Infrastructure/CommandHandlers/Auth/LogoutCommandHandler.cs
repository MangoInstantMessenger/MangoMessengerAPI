using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.DTO.Responses.Auth;
using MediatR;

namespace MangoAPI.Infrastructure.CommandHandlers.Auth
{
    public class LogoutCommandHandler : IRequestHandler<LogoutCommand, LogoutResponse>
    {
        private readonly IJwtRefreshService _jwtRefreshService;
        private readonly IRequestMetadataService _metadataService;

        public LogoutCommandHandler(IJwtRefreshService jwtRefreshService, IRequestMetadataService metadataService)
        {
            _jwtRefreshService = jwtRefreshService;
            _metadataService = metadataService;
        }

        public async Task<LogoutResponse> Handle(LogoutCommand request, CancellationToken cancellationToken)
        {
            var requestMetadata = _metadataService.GetRequestMetadata();

            var validationResult = await _jwtRefreshService.VerifyUserRefreshTokenAsync(request.RefreshTokenId,
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

            var result = await _jwtRefreshService.RevokeRefreshTokenAsync(request.RefreshTokenId,
                cancellationToken);

            if (!result.Success)
            {
                return LogoutResponse.InvalidOrEmptyRefreshToken;
            }

            return LogoutResponse.SuccessResponse;
        }
    }
}
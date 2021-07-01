using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Constants;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.DTO.Responses.Auth;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.CommandHandlers.Auth
{
    public class LogoutAllCommandHandler : IRequestHandler<LogoutAllCommand, LogoutResponse>
    {
        private readonly ICookieService _cookieService;
        private readonly IJwtRefreshService _jwtRefreshService;
        private readonly IRequestMetadataService _metadataService;
        private readonly MangoPostgresDbContext _postgresDbContext;

        public LogoutAllCommandHandler(ICookieService cookieService, IJwtRefreshService jwtRefreshService, 
            IRequestMetadataService metadataService, MangoPostgresDbContext postgresDbContext)
        {
            _cookieService = cookieService;
            _jwtRefreshService = jwtRefreshService;
            _metadataService = metadataService;
            _postgresDbContext = postgresDbContext;
        }

        public async Task<LogoutResponse> Handle(LogoutAllCommand request, CancellationToken cancellationToken)
        {
            var requestMetadata = _metadataService.GetRequestMetadata();
            var refreshTokenId = _cookieService.Get(CookieConstants.MangoRefreshTokenId);
            
            var validationResult = await _jwtRefreshService.VerifyUserRefreshTokenAsync(refreshTokenId,
                requestMetadata,
                cancellationToken);
            
            if (validationResult.IsSuspicious)
            {
                return LogoutResponse.SuspiciousLogout;
            }

            if (!validationResult.Success)
            {
                return LogoutResponse.InvalidOrEmptyRefreshToken;
            }

            var token = await _postgresDbContext.RefreshTokens
                .FirstOrDefaultAsync(x => x.Id == refreshTokenId, cancellationToken);

            var userTokens = _postgresDbContext
                .RefreshTokens
                .Where(x => x.UserId == token.UserId)
                .ToList();
            
            _postgresDbContext.RefreshTokens.RemoveRange(userTokens);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);
            
            return LogoutResponse.SuccessResponse;
        }
    }
}
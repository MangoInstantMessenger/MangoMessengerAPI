using System.Threading.Tasks;
using MangoAPI.Application.Common;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Infrastructure.Services
{
    public class RequestMetadataService : IRequestMetadataService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<UserEntity> _userManager;

        public RequestMetadataService(IHttpContextAccessor httpContextAccessor, UserManager<UserEntity> userManager)
        {
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        public RequestMetadata GetRequestMetadata() => new()
        {
            IpAddress = _httpContextAccessor.HttpContext?.Request.HttpContext.Connection.RemoteIpAddress?.MapToIPv6().ToString(),
            UserAgent = _httpContextAccessor.HttpContext?.Request.Headers["User-Agent"].ToString(),
            FingerPrintSalt = _httpContextAccessor.HttpContext?.Request.Headers["X-FingerprintSalt"].ToString(),
            UserId = _userManager.GetUserId(_httpContextAccessor.HttpContext?.User)
        };

        public async Task<UserEntity> GetUserFromRequestMetadataAsync() =>
            _httpContextAccessor?.HttpContext?.User == null ? null :
                await _userManager.GetUserAsync(_httpContextAccessor?.HttpContext?.User);
    }
}
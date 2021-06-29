using MangoAPI.Application.Common;
using MangoAPI.Application.Services;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.Infrastructure.Services
{
    public class RequestMetadataService:IRequestMetadataService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public RequestMetadataService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        
        public RequestMetadata GetRequestMetadata() => new()
        {
            IpAddress = _httpContextAccessor.HttpContext.Request.HttpContext.Connection.RemoteIpAddress?.MapToIPv6().ToString(),
            UserAgent = _httpContextAccessor.HttpContext.Request.Headers["User-Agent"].ToString(),
            FingerPrintSalt = _httpContextAccessor.HttpContext.Request.Headers["X-FingerprintSalt"].ToString(),
        };
    }
}
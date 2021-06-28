using MangoAPI.DTO.Common;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.WebApp.Extensions
{
    public static class RequestExtensions
    {
        public static RequestMetadata GetRequestMetadata(this HttpRequest httpRequest)
            => new()
            {
                IpAddress = httpRequest.HttpContext.Connection.RemoteIpAddress?.MapToIPv6().ToString(),
                UserAgent = httpRequest.Headers["User-Agent"].ToString(),
                FingerPrint = "777777"  // TODO: remove this in future and discuss solution
            };
    }
}
using MangoAPI.DTO.Common;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.WebApp.Extensions
{
    public static class RequestExtensions
    {
        public static RequestMetadata GetRequestMetadata(this HttpRequest httpRequest)
            => new()
            {
                IpAddress = httpRequest.HttpContext.Connection.RemoteIpAddress?.MapToIPv4().ToString(),
                UserAgent = httpRequest.Headers["User-Agent"].ToString()
            };
    }
}
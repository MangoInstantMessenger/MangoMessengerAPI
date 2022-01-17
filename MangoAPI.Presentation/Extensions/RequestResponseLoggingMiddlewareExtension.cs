using MangoAPI.Presentation.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace MangoAPI.Presentation.Extensions;

public static class RequestResponseLoggingMiddlewareExtension
{
    public static IApplicationBuilder UseRequestResponseLogging(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<RequestResponseLoggingMiddleware>();
    }
}
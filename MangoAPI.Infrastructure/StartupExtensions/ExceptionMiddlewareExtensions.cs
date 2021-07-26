using MangoAPI.Infrastructure.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace MangoAPI.Infrastructure.StartupExtensions
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
using MangoAPI.Presentation.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace MangoAPI.Presentation.Extensions
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
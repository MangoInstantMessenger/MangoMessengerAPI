namespace MangoAPI.Presentation.Extensions
{
    using MangoAPI.Presentation.Middlewares;
    using Microsoft.AspNetCore.Builder;

    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}

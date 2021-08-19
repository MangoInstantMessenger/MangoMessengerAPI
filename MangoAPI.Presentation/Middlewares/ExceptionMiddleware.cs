namespace MangoAPI.Presentation.Middlewares
{
    using System;
    using System.Net;
    using System.Threading.Tasks;
    using FluentValidation;
    using MangoAPI.BusinessLogic.BusinessExceptions;
    using MangoAPI.BusinessLogic.Responses;
    using Microsoft.AspNetCore.Http;

    public class ExceptionMiddleware
    {
        private readonly RequestDelegate next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var errorContext = new ErrorContext(exception.Message, exception)
            {
                StatusCode = exception switch
                {
                    ValidationException => HttpStatusCode.BadRequest,
                    BusinessException => HttpStatusCode.Conflict,
                    _ => HttpStatusCode.InternalServerError,
                },
            };

            await ThrowError(context, errorContext);
        }

        private static async Task ThrowError(HttpContext context, ErrorContext errorContext)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)errorContext.StatusCode;
            await context.Response.WriteAsync(new ErrorResponse
            {
                Success = false,
                ErrorMessage = errorContext.ErrorMessage,
                ErrorDetails = errorContext.Exception.StackTrace,
                StatusCode = (int)errorContext.StatusCode,
            }.ToString());
        }
    }

    internal class ErrorContext
    {
        public ErrorContext(string errorMessage, Exception exception)
        {
            ErrorMessage = errorMessage;
            StatusCode = HttpStatusCode.BadRequest;
            Exception = exception;
        }

        public Exception Exception { get; }

        public HttpStatusCode StatusCode { get; init; }

        public string ErrorMessage { get; }
    }
}

using System;
using System.Net;
using System.Threading.Tasks;
using FluentValidation;
using MangoAPI.Domain.Constants;
using MangoAPI.DTO.Responses;
using MangoAPI.Infrastructure.BusinessExceptions;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.Infrastructure.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            ErrorContext errorContext;
            
            switch (exception)
            {
                case ValidationException:
                    errorContext = new ErrorContext(exception.Message, exception);
                    await ThrowError(context, errorContext);
                    return;
                case BusinessException:
                    errorContext = new ErrorContext(exception.Message, exception);
                    await ThrowError(context, errorContext);
                    return;
                default:
                    errorContext = new ErrorContext(exception,
                        HttpStatusCode.InternalServerError,
                        ResponseMessageCodes.InternalServerError);

                    await ThrowError(context, errorContext);
                    break;
            }
        }

        private static async Task ThrowError(HttpContext context, ErrorContext errorContext)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int) errorContext.StatusCode;
            await context.Response.WriteAsync(new ErrorResponse
            {
                Success = false,
                ErrorMessage = errorContext.ErrorMessage,
                ErrorDetails = errorContext.Exception.Source,
                StatusCode = (int) errorContext.StatusCode
            }.ToString());
        }
    }

    internal class ErrorContext
    {
        public Exception Exception { get; set; }
        public HttpStatusCode StatusCode { get; }
        public string ErrorMessage { get; }

        public ErrorContext(string errorMessage, Exception exception)
        {
            ErrorMessage = errorMessage;
            StatusCode = HttpStatusCode.BadRequest;
            Exception = exception;
        }

        public ErrorContext(Exception exception, HttpStatusCode statusCode, string errorMessage)
        {
            Exception = exception;
            StatusCode = statusCode;
            ErrorMessage = errorMessage;
        }
    }
}
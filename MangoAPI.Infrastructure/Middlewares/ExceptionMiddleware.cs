using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Threading.Tasks;
using MangoAPI.Domain.Constants;
using MangoAPI.DTO.Responses;
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
            if (exception is ValidationException validationException)
            {
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int) HttpStatusCode.BadRequest;
                await context.Response.WriteAsync(new ErrorResponse
                {
                    Success = false,
                    ErrorMessage = ResponseMessageCodes.ValidationError,
                    ErrorDetails = validationException.Message,
                    StatusCode = (int) HttpStatusCode.BadRequest
                }.ToString());

                return;
            }

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int) HttpStatusCode.InternalServerError;
            await context.Response.WriteAsync(new ErrorResponse
            {
                Success = false,
                ErrorMessage = ResponseMessageCodes.ValidationError,
                ErrorDetails = exception.Message,
                StatusCode = (int) HttpStatusCode.BadRequest
            }.ToString());
        }
    }
}
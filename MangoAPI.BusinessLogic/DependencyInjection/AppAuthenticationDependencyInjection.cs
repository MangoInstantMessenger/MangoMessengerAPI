using System;
using System.Net;
using System.Text;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace MangoAPI.BusinessLogic.DependencyInjection;

public static class AppAuthenticationDependencyInjection
{
    public static IServiceCollection AddAppAuthentication(
        this IServiceCollection services,
        string mangoJwtSignKey,
        string mangoJwtIssuer,
        string mangoJwtAudience)
    {
        if (services == null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(mangoJwtSignKey));

        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
        {
            options.RequireHttpsMetadata = false;
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidIssuer = mangoJwtIssuer,
                ValidateIssuer = true,
                ValidAudience = mangoJwtAudience,
                ValidateAudience = true,
                ValidateLifetime = true,
                IssuerSigningKey = signingKey,
                ValidateIssuerSigningKey = true,
            };
            options.Events = new JwtBearerEvents
            {
                OnChallenge = async context =>
                {
                    context.HandleResponse();

                    context.Response.StatusCode = 401;
                    context.Response.ContentType = "application/json";

                    const string unauthorized = ResponseMessageCodes.Unauthorized;

                    await context.Response.WriteAsync(new ErrorResponse
                    {
                        StatusCode = HttpStatusCode.Unauthorized,
                        Success = false,
                        ErrorMessage = unauthorized,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[unauthorized],
                    }.ToString());
                },
            };
        });

        return services;
    }
}

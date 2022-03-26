using System.Net;
using System.Text;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace MangoAPI.Presentation.Extensions;

public static class AuthExtensions
{
    public static IServiceCollection AddAppAuthorization(this IServiceCollection services)
    {
        services.AddAuthorization(options =>
        {
            options.DefaultPolicy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                .Build();
        });
        return services;
    }

    public static IServiceCollection AddAppAuthentication(this IServiceCollection services)
    {
        var tokenKey = EnvironmentConstants.MangoJwtSignKey;
        var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenKey));

        services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, configure =>
            {
                configure.RequireHttpsMetadata = false;
                configure.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = EnvironmentConstants.MangoJwtIssuer,
                    ValidateIssuer = true,
                    ValidAudience = EnvironmentConstants.MangoJwtAudience,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    IssuerSigningKey = signingKey,
                    ValidateIssuerSigningKey = true,
                };
                configure.Events = new JwtBearerEvents
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
                            ErrorDetails = ResponseMessageCodes.ErrorDictionary[unauthorized]
                        }.ToString());
                    }
                };
            });

        return services;
    }
}
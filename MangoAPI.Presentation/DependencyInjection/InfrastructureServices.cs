using System;
using System.Net;
using System.Text;
using FluentValidation;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Pipelines;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Presentation.Constants;
using MangoAPI.Presentation.Controllers;
using MangoAPI.Presentation.Extensions;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace MangoAPI.Presentation.DependencyInjection;

public static class InfrastructureServices
{
    public static IServiceCollection AddAppInfrastructure(this IServiceCollection services,
        IConfiguration configuration)
    {
        if (services == null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        services.AddIdentityUsers();

        services.AddAppAuthorization();
        services.AddAppAuthentication(configuration);

        services.AddValidatorsFromAssembly(typeof(LoginCommandValidator).Assembly);

        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
        services.AddTransient(typeof(ResponseFactory<>));

        services.AddLogging();

        services.AddAutoMapper(typeof(ApiControllerBase));

        services.AddMediatR(typeof(RegisterCommandHandler).Assembly);

        services.AddHttpClient();

        return services;
    }

    private static IServiceCollection AddAppAuthorization(this IServiceCollection services)
    {
        if (services == null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        services.AddAuthorization(options =>
        {
            options.DefaultPolicy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                .Build();
        });

        return services;
    }

    private static IServiceCollection AddAppAuthentication(this IServiceCollection services,
        IConfiguration configuration)
    {
        if (services == null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        var mangoJwtSignKey = configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoJwtSignKey);
        var mangoJwtIssuer = configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoJwtIssuer);
        var mangoJwtAudience =
            configuration.GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoJwtAudience);

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
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[unauthorized]
                    }.ToString());
                }
            };
        });

        return services;
    }
}
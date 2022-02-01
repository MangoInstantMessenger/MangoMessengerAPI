using Azure.Storage.Blobs;
using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.Domain.Constants;
using MangoAPI.Presentation.Controllers;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.Presentation.Extensions;

public static class AppServicesExtensions
{
    public static IServiceCollection AddAppServices(this IServiceCollection services)
    {
        services.AddMediatR(typeof(RegisterCommandHandler).Assembly);
        services.AddScoped<IJwtGenerator, JwtGenerator>();
        services.AddScoped<IEmailSenderService, MailgunApiEmailSenderService>();
        services.AddScoped<PasswordHashService>();
        services.AddAutoMapper(typeof(ApiControllerBase));
        services.AddScoped<IUserManagerService, UserManagerService>();
        services.AddScoped<ISignInManagerService, SignInManagerService>();

        var blobConnection = EnvironmentConstants.MangoBlobUrl;
        services.AddSingleton(_ => new BlobServiceClient(blobConnection));
        services.AddScoped<IBlobService, BlobService>();
        services.AddHttpClient();

        return services;
    }
}
using MangoAPI.BusinessLogic.HubConfig;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MangoAPI.Presentation.Middlewares;
using System;
using System.Text.Json;
using System.Threading;
using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.DependencyInjection;
using MangoAPI.Domain.Constants;
using MangoAPI.Presentation.Controllers;
using MangoAPI.Presentation.Extensions;

namespace MangoAPI.Presentation;

public class Startup
{
    private readonly IConfiguration _configuration;
    private const string CorsPolicy = "MyDefaultCorsPolicy";

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.ConfigureExceptionHandler();

        app.UseHttpsRedirection();

        app.UseRouting();
        app.UseCors(CorsPolicy);

        app.UseStaticFiles();

        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MangoAPI v1"));

        app.UseAuthorization();

        app.UseForwardedHeaders(new ForwardedHeadersOptions
        {
            ForwardedHeaders = ForwardedHeaders.XForwardedFor |
                               ForwardedHeaders.XForwardedProto,
        });

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers().RequireCors(CorsPolicy);
            endpoints.MapHub<ChatHub>("/notify").RequireCors(CorsPolicy);
        });

        // https://stackoverflow.com/a/62374509
        app.Map("/app", spaApp => { spaApp.UseSpa(spa => { spa.Options.SourcePath = "/wwwroot"; }); });

        app.MigrateDatabase();
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSignalR();

        services.AddControllers().AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.WriteIndented = true;
            options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        });

        var databaseConnectionString = _configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoDatabaseUrl);

        var mangoBlobUrl = _configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoBlobUrl);

        var mangoBlobContainerName = _configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoBlobContainer);

        var mangoBlobAccess = _configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoBlobAccess);

        var mangoJwtSignKey = _configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoJwtSignKey);

        var mangoJwtIssuer = _configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoJwtIssuer);

        var mangoJwtAudience = _configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoJwtAudience);

        const int mangoJwtLifetimeMinutes = EnvironmentConstants.MangoJwtLifetimeMinutes;

        const int mangoRefreshTokenLifetimeDays = EnvironmentConstants.MangoRefreshTokenLifetimeDays;

        var mailgunApiBaseUrl = _configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoMailgunApiBaseUrl);

        var mailgunApiKey = _configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoMailgunApiKey);

        var frontendAddress = _configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoFrontendAddress);

        var notificationEmail = _configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoEmailNotificationsAddress);

        var mailgunApiDomain = _configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoMailgunApiDomain);

        services.AddDatabaseContextServices(databaseConnectionString);

        services.AddAppInfrastructure(mangoJwtSignKey, mangoJwtIssuer, mangoJwtAudience);

        services.AddMessengerServices(
            mangoBlobUrl,
            mangoBlobContainerName,
            mangoBlobAccess,
            mangoJwtSignKey,
            mangoJwtIssuer,
            mangoJwtAudience,
            mangoJwtLifetimeMinutes,
            mangoRefreshTokenLifetimeDays,
            mailgunApiBaseUrl,
            mailgunApiKey,
            frontendAddress,
            notificationEmail,
            mailgunApiDomain);

        services.AddSwagger();

        services.ConfigureCors(_configuration, CorsPolicy);

        services.AddSpaStaticFiles(configuration => { configuration.RootPath = "wwwroot"; });

        services.AddHttpContextAccessor();

        services.AddTransient<ICorrelationContext, CorrelationContext>();

        services.AddApplicationInsightsTelemetry();

        services.AddAutoMapper(typeof(ApiControllerBase));

        services.AddMvc();
    }
}

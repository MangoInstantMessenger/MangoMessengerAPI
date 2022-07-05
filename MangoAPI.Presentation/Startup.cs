using System.Text.Json;
using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.DependencyInjection;
using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.Domain.Constants;
using MangoAPI.Presentation.Controllers;
using MangoAPI.Presentation.Extensions;
using MangoAPI.Presentation.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MangoAPI.Presentation;

public class Startup
{
    private const string CorsPolicy = "MyDefaultCorsPolicy";
    private readonly IConfiguration configuration;

    public Startup(IConfiguration configuration)
    {
        this.configuration = configuration;
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

        var databaseConnectionString = configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoDatabaseUrl);

        var mangoBlobUrl = configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoBlobUrl);

        var mangoBlobContainerName = configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoBlobContainer);

        var mangoBlobAccess = configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoBlobAccess);

        var mangoJwtSignKey = configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoJwtSignKey);

        var mangoJwtIssuer = configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoJwtIssuer);

        var mangoJwtAudience = configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoJwtAudience);

        const int mangoJwtLifetimeMinutes = EnvironmentConstants.MangoJwtLifetimeMinutes;

        const int mangoRefreshTokenLifetimeDays = EnvironmentConstants.MangoRefreshTokenLifetimeDays;

        var mailgunApiBaseUrl = configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoMailgunApiBaseUrl);

        var mailgunApiKey = configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoMailgunApiKey);

        var frontendAddress = configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoFrontendAddress);

        var notificationEmail = configuration
            .GetValueFromAppSettingsOrEnvironment(EnvironmentConstants.MangoEmailNotificationsAddress);

        var mailgunApiDomain = configuration
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

        services.ConfigureCors(configuration, CorsPolicy);

        services.AddSpaStaticFiles(config => { config.RootPath = "wwwroot"; });

        services.AddHttpContextAccessor();

        services.AddTransient<ICorrelationContext, CorrelationContext>();

        services.AddApplicationInsightsTelemetry();

        services.AddAutoMapper(typeof(ApiControllerBase));

        services.AddMvc();
    }
}

using System.Text.Json;
using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.DependencyInjection;
using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.Domain.Constants;
using MangoAPI.Presentation.Controllers;
using MangoAPI.Presentation.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;

namespace MangoAPI.Presentation;

public class Startup
{
    private const string CorsPolicy = "MangoCorsPolicy";
    private readonly IConfiguration configuration;
    private readonly string version;
    private readonly string swaggerTitle;

    public Startup(IConfiguration configuration)
    {
        var parameterService = new ParameterService();
        
        this.configuration = configuration;
        version = parameterService.GetVersionParameter();
        swaggerTitle = $"MangoAPI v{version}";
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

        app.UseSwaggerUI(c => c.SwaggerEndpoint($"/swagger/v{version}/swagger.json", swaggerTitle));

        app.UseAuthorization();

        app.UseForwardedHeaders(new ForwardedHeadersOptions
        {
            ForwardedHeaders = ForwardedHeaders.XForwardedFor |
                               ForwardedHeaders.XForwardedProto,
        });

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapHub<ChatHub>("/notify");
        });

        // https://stackoverflow.com/a/62374509
        app.Map("/app", builder => builder.UseSpa(spa => spa.Options.SourcePath = "/wwwroot"));

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

        var databaseUrl = TryGetFromEnvironment(EnvironmentConstants.DatabaseUrl, configuration);

        var blobUrl = configuration[EnvironmentConstants.BlobUrl];

        var blobContainerName = configuration[EnvironmentConstants.BlobContainer];

        var blobAccess = configuration[EnvironmentConstants.BlobAccess];

        var jwtSignKey = configuration[EnvironmentConstants.JwtSignKey];

        var jwtIssuer = configuration[EnvironmentConstants.JwtIssuer];

        var jwtAudience = configuration[EnvironmentConstants.JwtAudience];

        const int jwtLifetimeMinutes = EnvironmentConstants.JwtLifetimeMinutes;

        const int refreshTokenLifetimeDays = EnvironmentConstants.RefreshTokenLifetimeDays;

        services.AddDatabaseContextServices(databaseUrl);

        services.AddAppInfrastructure(jwtSignKey, jwtIssuer, jwtAudience);

        services.AddMessengerServices(
            blobUrl,
            blobContainerName,
            blobAccess,
            jwtSignKey,
            jwtIssuer,
            jwtAudience,
            jwtLifetimeMinutes,
            refreshTokenLifetimeDays);

        var apiInfo = new OpenApiInfo
        {
#pragma warning disable IDE0055
            Title = swaggerTitle, Version = version, Description = "Mango Messenger ASP .NET 6 Web API",
#pragma warning restore IDE0055
        };

        services.AddSwaggerGen(c => { c.SwaggerDoc($"v{version}", apiInfo); });

        services.ConfigureCors(configuration, CorsPolicy);

        services.AddSpaStaticFiles(config => { config.RootPath = "wwwroot"; });

        services.AddHttpContextAccessor();

        services.AddTransient<ICorrelationContext, CorrelationContext>();

        services.AddAutoMapper(typeof(ApiControllerBase));

        services.AddMvc();

        services.AddApplicationInsightsTelemetry();

        services.AddLogging();
    }

    /// <summary>
    /// This method is created as workaround for docker compose. Parameters in docker compose is better to pass via
    /// environment variables.
    /// </summary>
    private static string TryGetFromEnvironment(string key, IConfiguration configuration)
    {
        var value = Environment.GetEnvironmentVariable(key) ?? configuration[key];

        return value;
    }
}
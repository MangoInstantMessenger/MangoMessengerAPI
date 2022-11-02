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

namespace MangoAPI.Presentation;

public class Startup
{
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

        var databaseUrl = configuration[EnvironmentConstants.DatabaseUrl];

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

        services.AddSwagger();

        services.AddSpaStaticFiles(config => { config.RootPath = "wwwroot"; });

        services.AddHttpContextAccessor();

        services.AddTransient<ICorrelationContext, CorrelationContext>();

        services.AddApplicationInsightsTelemetry();

        services.AddAutoMapper(typeof(ApiControllerBase));

        services.AddMvc();
    }
}

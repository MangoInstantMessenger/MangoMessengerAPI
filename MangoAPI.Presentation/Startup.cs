using System.Reflection;
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

namespace MangoAPI.Presentation;

public class Startup
{
    private const string CorsPolicy = "MangoCorsPolicy";
    private readonly IConfiguration configuration;
    private readonly string version;
    private readonly string swaggerTitle;

    public Startup(IConfiguration configuration)
    {
        this.configuration = configuration;
        version = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "1";
        swaggerTitle = $"MangoAPI v{version}";
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            _ = app.UseDeveloperExceptionPage();
        }

        app.ConfigureExceptionHandler();

        _ = app.UseHttpsRedirection();

        _ = app.UseRouting();
        _ = app.UseCors(CorsPolicy);

        _ = app.UseStaticFiles();

        _ = app.UseSwagger();

        _ = app.UseSwaggerUI(c => c.SwaggerEndpoint($"/swagger/v{version}/swagger.json", swaggerTitle));

        _ = app.UseAuthorization();

        _ = app.UseForwardedHeaders(new ForwardedHeadersOptions
        {
            ForwardedHeaders = ForwardedHeaders.XForwardedFor |
                               ForwardedHeaders.XForwardedProto,
        });

        _ = app.UseEndpoints(endpoints =>
        {
            _ = endpoints.MapControllers();
            _ = endpoints.MapHub<ChatHub>("/notify");
        });

        // https://stackoverflow.com/a/62374509
        _ = app.Map("/app", builder => builder.UseSpa(spa => spa.Options.SourcePath = "/wwwroot"));

        app.MigrateDatabase();
    }

    public void ConfigureServices(IServiceCollection services)
    {
        _ = services.AddSignalR();

        _ = services.AddControllers().AddJsonOptions(options =>
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

        _ = services.AddDatabaseContextServices(databaseUrl);

        _ = services.AddAppInfrastructure(jwtSignKey, jwtIssuer, jwtAudience);

        _ = services.AddMessengerServices(
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
            Title = swaggerTitle,
            Version = version,
            Description = "Mango Messenger ASP .NET 6 Web API",
        };

        _ = services.AddSwaggerGen(c => { c.SwaggerDoc($"v{version}", apiInfo); });

        _ = services.ConfigureCors(configuration, CorsPolicy);

        services.AddSpaStaticFiles(config => { config.RootPath = "wwwroot"; });

        _ = services.AddHttpContextAccessor();

        _ = services.AddTransient<ICorrelationContext, CorrelationContext>();

        _ = services.AddAutoMapper(typeof(ApiControllerBase));

        _ = services.AddMvc();
    }
}

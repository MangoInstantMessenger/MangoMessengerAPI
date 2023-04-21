using FluentValidation;
using System.Text.Json;
using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.DependencyInjection;
using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.BusinessLogic.Pipelines;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Presentation.Controllers;
using MangoAPI.Presentation.Middlewares;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace MangoAPI.Presentation;

public class Startup
{
    private const string CorsPolicy = "MangoCorsPolicy";
    private readonly IConfiguration configuration;
    private readonly string version;
    private readonly string swaggerTitle;

    public Startup(IConfiguration configuration)
    {
        var versionService = new VersionService();

        this.configuration = configuration;
        version = versionService.GetVersion();
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
        app.Map(RoutingConstants.Chats, builder => builder.UseSpa(spa => spa.Options.SourcePath = "/wwwroot"));
        app.Map(RoutingConstants.Contacts, builder => builder.UseSpa(spa => spa.Options.SourcePath = "/wwwroot"));
        app.Map(RoutingConstants.Settings, builder => builder.UseSpa(spa => spa.Options.SourcePath = "/wwwroot"));
        app.Map(RoutingConstants.CreateGroup, builder => builder.UseSpa(spa => spa.Options.SourcePath = "/wwwroot"));
        app.Map(RoutingConstants.Register, builder => builder.UseSpa(spa => spa.Options.SourcePath = "/wwwroot"));
        app.Map(RoutingConstants.Login, builder => builder.UseSpa(spa => spa.Options.SourcePath = "/wwwroot"));

        app.MigrateDatabase();
        Task.FromResult(app.InitializeAzureBlobAsync());
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

        var mangoUserPassword = configuration[EnvironmentConstants.MangoUserPassword];

        const int jwtLifetimeMinutes = EnvironmentConstants.JwtLifetimeMinutes;

        const int refreshTokenLifetimeDays = EnvironmentConstants.RefreshTokenLifetimeDays;

        services.AddDatabaseContextServices(databaseUrl);

        services.AddSwagger(title: swaggerTitle, version: version);

        services.AddAzureBlobServices(
            blobUrl,
            blobContainerName,
            blobAccess);

        services.AddJwtGeneratorServices(
            jwtIssuer,
            jwtAudience,
            jwtSignKey,
            jwtLifetimeMinutes,
            refreshTokenLifetimeDays);

        services.AddSingleton<IVersionService, VersionService>();

        services.AddSingleton<IPasswordService, PasswordService>();

        services.AddSingleton<IMangoUserSettings, MangoUserSettings>(_ => new MangoUserSettings(mangoUserPassword));

        services.AddScoped<IAvatarService, AvatarService>();

        services.AddValidatorsFromAssembly(typeof(LoginCommandValidator).Assembly);

        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

        services.AddTransient(typeof(ResponseFactory<>));

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(RegisterCommandHandler).Assembly));

        services.AddSignalR();

        services.AddAppAuthorization();

        services.AddAppAuthentication(
            jwtSignKey,
            jwtIssuer,
            jwtAudience);

        services.AddLogging();

        services.AddHttpClient();

        services.ConfigureCors(configuration, CorsPolicy);

        services.AddSpaStaticFiles(config => { config.RootPath = "wwwroot"; });

        services.AddHttpContextAccessor();

        services.AddTransient<ICorrelationContext, CorrelationContext>();

        services.AddAutoMapper(typeof(ApiControllerBase<AppInfoController>));

        services.AddMvc();

        services.AddApplicationInsightsTelemetry();

        services.AddLogging();
    }
}
using MangoAPI.BusinessLogic.HubConfig;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MangoAPI.Presentation.DependencyInjection;
using MangoAPI.Presentation.Middlewares;
using System.Text.Json;

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

        var shouldMigrate = _configuration.GetValue<bool>("ShouldMigrateDatabase");

        if (shouldMigrate)
        {
            app.MigrateDatabase();
        }
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSignalR();

        services.AddControllers().AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.WriteIndented = true;
            options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        });

        services.AddAppInfrastructure(_configuration);

        services.AddPostgresDatabaseService(_configuration);

        services.AddMessengerServices(_configuration);

        services.AddSwagger();

        services.ConfigureCors(_configuration, CorsPolicy);

        services.AddMvc();
    }
}
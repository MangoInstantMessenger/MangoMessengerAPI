using System;
using MangoAPI.Application.Services;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.Presentation.Extensions
{
    public static class DbExtensions
    {
        public static IServiceCollection AddPostgresDb(this IServiceCollection services)
        {
            var connectionString = EnvironmentConstants.MangoDatabaseUrl;

            connectionString = StringService.ConvertHerokuDbConnection(connectionString);

            services.AddDbContext<MangoPostgresDbContext>(options =>
            {
                options.UseNpgsql(connectionString ??
                              throw new InvalidOperationException("Wrong Connection String in Startup class."));
                options.EnableSensitiveDataLogging();
            });
            return services;
        }
    }
}
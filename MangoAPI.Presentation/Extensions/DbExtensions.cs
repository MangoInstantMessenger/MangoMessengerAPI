namespace MangoAPI.Presentation.Extensions
{
    using Application.Services;
    using DataAccess.Database;
    using Domain.Constants;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System;

    public static class DbExtensions
    {
        public static IServiceCollection AddPostgresDb(this IServiceCollection services)
        {
            var connectionString = EnvironmentConstants.DbConnectionString;

            connectionString = HerokuStringParser.Convert(connectionString);

            services.AddDbContext<MangoPostgresDbContext>(options =>
            {
                options.UseNpgsql(connectionString ??
                              throw new InvalidOperationException("Wrong Connection String in Startup class."));
                options.EnableSensitiveDataLogging(true);
            });
            return services;
        }
    }
}
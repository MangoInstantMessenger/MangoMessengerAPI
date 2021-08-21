namespace MangoAPI.Presentation.Extensions
{
    using System;
    using Application.Services;
    using DataAccess.Database;
    using Domain.Constants;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public static class DbExtensions
    {
        public static IServiceCollection AddPostgresDb(this IServiceCollection services)
        {
            var connectionString = EnvironmentConstants.DbConnectionString;

            connectionString = HerokuStringParser.Convert(connectionString);

            services.AddDbContext<MangoPostgresDbContext>(opt =>
                opt.UseNpgsql(connectionString ??
                              throw new InvalidOperationException("Wrong Connection String in Startup class.")));
            return services;
        }
    }
}

using System;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MangoAPI.Infrastructure.Deploy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.Infrastructure.StartupExtensions
{
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
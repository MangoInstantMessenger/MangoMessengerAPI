using System;
using MangoAPI.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.BusinessLogic.DependencyInjection;

public static class DatabaseDependencyInjection
{
    public static IServiceCollection AddDatabaseContextServices(
        this IServiceCollection services,
        string connectionString)
    {
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new ArgumentNullException(nameof(connectionString));
        }

        _ = services.AddDbContext<MangoDbContext>(options =>
        {
            _ = options.UseSqlServer(connectionString);
        });

        return services;
    }
}
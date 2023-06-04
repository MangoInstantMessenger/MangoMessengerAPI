using System;
using MangoAPI.Infrastructure.Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace MangoAPI.BusinessLogic.DependencyInjection;

public static class DatabaseMigrator
{
    public static void MigrateDatabase(this IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
            .CreateScope();

        using var context = serviceScope.ServiceProvider.GetService<MangoDbContext>();

        if (context == null)
        {
            throw new InvalidOperationException("Database context is NULL at Migrator service.");
        }

        if (context.Database.GetPendingMigrations().Any())
        {
            context.Database.Migrate();
        }
    }
}

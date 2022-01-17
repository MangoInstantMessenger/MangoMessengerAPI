using MangoAPI.Application.Services;
using MangoAPI.Domain.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace MangoAPI.DataAccess.Database
{
    public class DesignTimeUserDbContextFactory : IDesignTimeDbContextFactory<MangoPostgresDbContext>
    {
        public MangoPostgresDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<MangoPostgresDbContext>();
            var connectionString = EnvironmentConstants.MangoDatabaseUrl;

            connectionString = StringService.ConvertHerokuDbConnection(connectionString);

            options.UseNpgsql(connectionString ?? throw new ArgumentNullException(nameof(connectionString)));

            options.EnableSensitiveDataLogging();

            return new MangoPostgresDbContext(options.Options);
        }
    }
}
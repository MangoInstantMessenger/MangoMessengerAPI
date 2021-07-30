using System;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MangoAPI.Infrastructure.Database
{
    public class DesignTimeUserDbContextFactory : IDesignTimeDbContextFactory<MangoPostgresDbContext>
    {
        public MangoPostgresDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MangoPostgresDbContext>();

            var connectionString = EnvironmentConstants.DbConnectionString;

            connectionString = HerokuStringParser.Convert(connectionString);

            optionsBuilder.UseNpgsql(connectionString ??
                                     throw new InvalidOperationException(
                                         "Wrong Connection String in DesignTimeUserDbContextFactory class."));

            return new MangoPostgresDbContext(optionsBuilder.Options);
        }
    }
}
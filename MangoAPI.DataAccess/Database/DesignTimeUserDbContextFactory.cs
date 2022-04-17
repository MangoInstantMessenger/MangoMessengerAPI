using MangoAPI.Application.Services;
using MangoAPI.Domain.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace MangoAPI.DataAccess.Database;

public class DesignTimeUserDbContextFactory : IDesignTimeDbContextFactory<MangoPostgresDbContext>
{
    private readonly string _mangoDatabaseUrl;

    public DesignTimeUserDbContextFactory()
    {
        var configuration = new ConfigurationBuilder().Build();

        _mangoDatabaseUrl = configuration.AsEnumerable().First(t => t.Key == "MANGO_DATABASE_URL").Value;
    }
    
    public MangoPostgresDbContext CreateDbContext(string[] args)
    {
        var options = new DbContextOptionsBuilder<MangoPostgresDbContext>();
        var connectionString = _mangoDatabaseUrl;

        connectionString = StringService.ConvertHerokuDbConnection(connectionString);

        options.UseNpgsql(connectionString ?? throw new ArgumentNullException(nameof(connectionString)));

        options.EnableSensitiveDataLogging();

        return new MangoPostgresDbContext(options.Options);
    }
}
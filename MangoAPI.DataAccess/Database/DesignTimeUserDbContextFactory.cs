using MangoAPI.Application.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace MangoAPI.DataAccess.Database;

public class DesignTimeUserDbContextFactory : IDesignTimeDbContextFactory<MangoPostgresDbContext>
{
    private readonly string _mangoDatabaseUrl;

    public DesignTimeUserDbContextFactory()
    {
        //This needs to be deleted and changed
        _mangoDatabaseUrl = Environment.GetEnvironmentVariable("MANGO_DATABASE_URL");
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
using MangoAPI.Application.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MangoAPI.DataAccess.Exceptions;
using System;

namespace MangoAPI.DataAccess.Database;

public class DesignTimeUserDbContextFactory : IDesignTimeDbContextFactory<MangoDbContext>
{
    private readonly string _mangoDatabaseUrl;

    public DesignTimeUserDbContextFactory()
    {
        //This needs to be deleted and changed
        _mangoDatabaseUrl = Environment.GetEnvironmentVariable("MANGO_DATABASE_URL");
    }
    
    public MangoDbContext CreateDbContext(string[] args)
    {
        var options = new DbContextOptionsBuilder<MangoDbContext>();
        var connectionString = _mangoDatabaseUrl;

        connectionString = StringService.ConvertHerokuDbConnection(connectionString);

        options.UseNpgsql(connectionString ?? throw new EnvironmentVariableException(nameof(connectionString)));

        options.EnableSensitiveDataLogging();

        return new MangoDbContext(options.Options);
    }
}
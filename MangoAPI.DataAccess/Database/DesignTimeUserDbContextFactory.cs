using MangoAPI.Application.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MangoAPI.DataAccess.Exceptions;
using System;
using MangoAPI.Domain.Constants;

namespace MangoAPI.DataAccess.Database;

public class DesignTimeUserDbContextFactory : IDesignTimeDbContextFactory<MangoDbContext>
{
    private readonly string _mangoDatabaseUrl;

    public DesignTimeUserDbContextFactory()
    {
        _mangoDatabaseUrl = Environment.GetEnvironmentVariable(EnvironmentConstants.MangoDatabaseUrl)
                            ?? throw new EnvironmentVariableException(EnvironmentConstants.MangoDatabaseUrl);
    }

    public MangoDbContext CreateDbContext(string[] args)
    {
        var options = new DbContextOptionsBuilder<MangoDbContext>();
        
        var connectionString = _mangoDatabaseUrl;

        connectionString = StringService.ConvertHerokuDbConnection(connectionString);

        options.UseNpgsql(connectionString);

        options.EnableSensitiveDataLogging();

        return new MangoDbContext(options.Options);
    }
}
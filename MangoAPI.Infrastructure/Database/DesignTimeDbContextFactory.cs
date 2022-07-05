using System;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Exceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MangoAPI.Infrastructure.Database;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MangoDbContext>
{
    private readonly string mangoDatabaseUrl;

    public DesignTimeDbContextFactory()
    {
        mangoDatabaseUrl = Environment.GetEnvironmentVariable(EnvironmentConstants.MangoDatabaseUrl)
                            ?? throw new EnvironmentVariableException(EnvironmentConstants.MangoDatabaseUrl);
    }

    public MangoDbContext CreateDbContext(string[] args)
    {
        var options = new DbContextOptionsBuilder<MangoDbContext>();

        options.UseSqlServer(mangoDatabaseUrl);

        return new MangoDbContext(options.Options);
    }
}

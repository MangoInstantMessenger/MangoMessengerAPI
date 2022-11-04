using MangoAPI.Application.Services;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Exceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MangoAPI.Infrastructure.Database;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MangoDbContext>
{
    private readonly string mangoDatabaseUrl;

    public DesignTimeDbContextFactory()
    {
        var appSettingsPath = AppSettingsService.GetAppSettingsPath();

        var configuration = new ConfigurationBuilder().AddJsonFile(appSettingsPath).Build();

        mangoDatabaseUrl = configuration[EnvironmentConstants.DatabaseUrl]
                            ?? throw new AppSettingException(EnvironmentConstants.DatabaseUrl);
    }

    public MangoDbContext CreateDbContext(string[] args)
    {
        var options = new DbContextOptionsBuilder<MangoDbContext>();

        options.UseSqlServer(mangoDatabaseUrl);

        return new MangoDbContext(options.Options);
    }
}

namespace MangoAPI.Domain.Constants;

public static class EnvironmentConstants
{
    public const int JwtLifetimeMinutes = 60;

    public const int RefreshTokenLifetimeDays = 7;

    public const string JwtIssuer = "JwtIssuer";

    public const string JwtAudience = "JwtAudience";

    public const string JwtSignKey = "JwtSignKey";

    public const string DatabaseUrl = "DatabaseUrl";

    public const string IntegrationTestsDatabaseUrl = "IntegrationTestsDatabaseUrl";

    public const string BlobUrl = "BlobUrl";

    public const string BlobContainer = "BlobContainer";

    public const string BlobAccess = "BlobAccess";

    public const string MangoUserPassword = "MangoUserPassword";

    public const string MigrateDatabase = "MigrateDatabase";

    public const string InitializeBlob = "InitializeBlob";
}
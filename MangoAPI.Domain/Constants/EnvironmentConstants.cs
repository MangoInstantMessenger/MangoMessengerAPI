namespace MangoAPI.Domain.Constants;

public static class EnvironmentConstants
{
    public const int JwtLifetimeMinutes = 60;

    public const int RefreshTokenLifetimeDays = 7;

    public const string JwtIssuer = "JWT_ISSUER";

    public const string JwtAudience = "JWT_AUDIENCE";

    public const string JwtSignKey = "JWT_SIGN_KEY";

    public const string DatabaseUrl = "DATABASE_URL";

    public const string IntegrationTestsDatabaseUrl = "INTEGRATION_TESTS_DATABASE_URL";

    public const string BlobUrl = "BLOB_URL";

    public const string BlobContainer = "BLOB_CONTAINER";

    public const string BlobAccess = "BLOB_ACCESS";
}

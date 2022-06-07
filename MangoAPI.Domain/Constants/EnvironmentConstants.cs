namespace MangoAPI.Domain.Constants;

public static class EnvironmentConstants
{
    public const int MangoJwtLifetimeMinutes = 60;

    public const int MangoRefreshTokenLifetimeDays = 7;

    public const string MangoJwtIssuer = "MANGO_JWT_ISSUER";

    public const string MangoJwtAudience = "MANGO_JWT_AUDIENCE";

    public const string MangoJwtSignKey = "MANGO_JWT_SIGN_KEY";

    public const string MangoSeedPassword = "MANGO_SEED_PASSWORD";

    public const string MangoEmailNotificationsAddress = "MANGO_EMAIL_NOTIFICATIONS_ADDRESS";

    public const string MangoFrontendAddress = "MANGO_FRONTEND_ADDRESS";

    public const string MangoDatabaseUrl = "MANGO_DATABASE_URL";
    
    public const string MangoIntegrationTestsDatabaseUrl = "MANGO_INTEGRATION_TESTS_DATABASE_URL";

    public const string MangoBlobUrl = "MANGO_BLOB_URL";

    public const string MangoBlobContainer = "MANGO_BLOB_CONTAINER";

    public const string MangoBlobAccess = "MANGO_BLOB_ACCESS";

    public const string MangoMailgunApiKey = "MANGO_MAILGUN_API_KEY";

    public const string MangoMailgunApiBaseUrl = "MANGO_MAILGUN_API_BASE_URL";

    public const string MangoMailgunApiDomain = "MANGO_MAILGUN_API_DOMAIN";

    public const string MangoJsonConfig = "appsettings.json";
}
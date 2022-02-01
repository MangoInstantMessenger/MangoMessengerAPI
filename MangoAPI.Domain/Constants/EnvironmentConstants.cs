using System;

namespace MangoAPI.Domain.Constants;

public static class EnvironmentConstants
{
    public static string MangoJwtIssuer => Environment.GetEnvironmentVariable("MANGO_JWT_ISSUER");

    public static string MangoJwtAudience => Environment.GetEnvironmentVariable("MANGO_JWT_AUDIENCE");

    public static string MangoJwtSignKey => Environment.GetEnvironmentVariable("MANGO_JWT_SIGN_KEY");

    public const int MangoJwtLifetime = 60;

    public const int MangoRefreshTokenLifetime = 7;

    public static string MangoEmailNotificationsAddress =>
        Environment.GetEnvironmentVariable("MANGO_EMAIL_NOTIFICATIONS_ADDRESS");

    public static string MangoFrontendAddress => Environment.GetEnvironmentVariable("MANGO_FRONTEND_ADDRESS");

    public static string MangoDatabaseUrl => Environment.GetEnvironmentVariable("MANGO_DATABASE_URL");

    public static string MangoSeedPassword => Environment.GetEnvironmentVariable("MANGO_SEED_PASSWORD");

    public static string MangoBlobUrl => Environment.GetEnvironmentVariable("MANGO_BLOB_URL");

    public static string MangoBlobContainer => Environment.GetEnvironmentVariable("MANGO_BLOB_CONTAINER");

    public static string MangoBlobAccess => Environment.GetEnvironmentVariable("MANGO_BLOB_ACCESS");

    public static string MangoMailgunApiKey => Environment.GetEnvironmentVariable("MANGO_MAILGUN_API_KEY");

    public static string MangoMailgunApiBaseUrl => Environment.GetEnvironmentVariable("MANGO_MAILGUN_API_BASE_URL");

    public static string MangoMailgunApiDomain => Environment.GetEnvironmentVariable("MANGO_MAILGUN_API_DOMAIN");
}
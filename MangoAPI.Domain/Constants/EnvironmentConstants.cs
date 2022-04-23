using System;
using System.Configuration;

namespace MangoAPI.Domain.Constants;

public static class EnvironmentConstants
{
    public static string MangoJwtIssuer =>
        Environment.GetEnvironmentVariable("MANGO_JWT_ISSUER") ??
        throw new ConfigurationErrorsException("MANGO_JWT_ISSUER is not set.");

    public static string MangoJwtAudience =>
        Environment.GetEnvironmentVariable("MANGO_JWT_AUDIENCE") ??
        throw new ConfigurationErrorsException("MANGO_JWT_AUDIENCE is not set.");

    public static string MangoJwtSignKey =>
        Environment.GetEnvironmentVariable("MANGO_JWT_SIGN_KEY") ??
        throw new ConfigurationErrorsException("MANGO_JWT_SIGN_KEY is not set.");

    public const int MangoJwtLifetime = 60;

    public const int MangoRefreshTokenLifetime = 7;

    public static string MangoEmailNotificationsAddress =>
        Environment.GetEnvironmentVariable("MANGO_EMAIL_NOTIFICATIONS_ADDRESS") ??
        throw new ConfigurationErrorsException("MANGO_EMAIL_NOTIFICATIONS_ADDRESS is not set.");

    public static string MangoFrontendAddress =>
        Environment.GetEnvironmentVariable("MANGO_FRONTEND_ADDRESS") ??
        throw new ConfigurationErrorsException("MANGO_FRONTEND_ADDRESS is not set.");

    public static string MangoDatabaseUrl =>
        Environment.GetEnvironmentVariable("MANGO_DATABASE_URL") ??
        throw new ConfigurationErrorsException("MANGO_DATABASE_URL is not set.");

    public static string MangoSeedPassword =>
        Environment.GetEnvironmentVariable("MANGO_SEED_PASSWORD") ??
        throw new ConfigurationErrorsException("MANGO_SEED_PASSWORD is not set.");

    public static string MangoBlobUrl =>
        Environment.GetEnvironmentVariable("MANGO_BLOB_URL") ??
        throw new ConfigurationErrorsException("MANGO_BLOB_URL is not set.");

    public static string MangoBlobContainer =>
        Environment.GetEnvironmentVariable("MANGO_BLOB_CONTAINER") ??
        throw new ConfigurationErrorsException("MANGO_BLOB_CONTAINER is not set.");

    public static string MangoBlobAccess =>
        Environment.GetEnvironmentVariable("MANGO_BLOB_ACCESS") ??
        throw new ConfigurationErrorsException("MANGO_BLOB_ACCESS is not set.");

    public static string MangoMailgunApiKey =>
        Environment.GetEnvironmentVariable("MANGO_MAILGUN_API_KEY") ??
        throw new ConfigurationErrorsException("MANGO_MAILGUN_API_KEY is not set.");

    public static string MangoMailgunApiBaseUrl =>
        Environment.GetEnvironmentVariable("MANGO_MAILGUN_API_BASE_URL") ??
        throw new ConfigurationErrorsException("MANGO_MAILGUN_API_BASE_URL is not set.");

    private static string MangoMailgunApiDomain =>
        Environment.GetEnvironmentVariable("MANGO_MAILGUN_API_DOMAIN") ??
        throw new ConfigurationErrorsException("MANGO_MAILGUN_API_DOMAIN is not set.");

    public static string MangoMailgunApiUrlWithDomain =>
        $"{MangoMailgunApiBaseUrl}/v3/{MangoMailgunApiDomain}/messages";
}
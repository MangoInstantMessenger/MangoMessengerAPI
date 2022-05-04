using System;
using Microsoft.Extensions.Configuration.EnvironmentVariables;
using Microsoft.Extensions.Configuration.Json;

namespace MangoAPI.Presentation.Constants;

public static class EnvironmentConstants
{
    public const int MangoJwtLifetime = 60;
    public const int MangoRefreshTokenLifetime = 7;
    public static string MangoJwtIssuer => "MANGO_JWT_ISSUER";
    public static string MangoJwtAudience => "MANGO_JWT_AUDIENCE";
    public static string MangoJwtSignKey => "MANGO_JWT_SIGN_KEY";
    public static string MangoEmailNotificationsAddress => "MANGO_EMAIL_NOTIFICATIONS_ADDRESS";
    public static string MangoFrontendAddress => "MANGO_FRONTEND_ADDRESS";
    public static string MangoDatabaseUrl => "MANGO_DATABASE_URL";
    public static string MangoSeedPassword => "MANGO_SEED_PASSWORD";
    public static string MangoBlobUrl => "MANGO_BLOB_URL";
    public static string MangoBlobContainer => "MANGO_BLOB_CONTAINER";
    public static string MangoBlobAccess => "MANGO_BLOB_ACCESS";
    public static string MangoMailgunApiKey => "MANGO_MAILGUN_API_KEY";
    public static string MangoMailgunApiBaseUrl => "MANGO_MAILGUN_API_BASE_URL";
    public static string MangoMailgunApiDomain => "MANGO_MAILGUN_API_DOMAIN";


    public static string MangoJsonConfig = "appsettings.json";
    
    public static Type MangoEnvConfigType = typeof(EnvironmentVariablesConfigurationProvider);
    public static Type MangoJsonConfigType = typeof(JsonConfigurationProvider);
}
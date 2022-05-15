using System;
using Microsoft.Extensions.Configuration.EnvironmentVariables;
using Microsoft.Extensions.Configuration.Json;

namespace MangoAPI.Presentation.Constants;

public static class EnvironmentConstants
{
    public const int MangoJwtLifetime = 60;

    public const int MangoRefreshTokenLifetime = 7;

    public const string MangoJwtIssuer = "MANGO_JWT_ISSUER";

    public const string MangoJwtAudience = "MANGO_JWT_AUDIENCE";

    public const string MangoJwtSignKey = "MANGO_JWT_SIGN_KEY";

    public const string MangoEmailNotificationsAddress = "MANGO_EMAIL_NOTIFICATIONS_ADDRESS";

    public const string MangoFrontendAddress = "MANGO_FRONTEND_ADDRESS";

    public const string MangoDatabaseUrl = "MANGO_DATABASE_URL";

    public const string MangoBlobUrl = "MANGO_BLOB_URL";

    public const string MangoBlobContainer = "MANGO_BLOB_CONTAINER";

    public const string MangoBlobAccess = "MANGO_BLOB_ACCESS";

    public const string MangoMailgunApiKey = "MANGO_MAILGUN_API_KEY";

    public const string MangoMailgunApiBaseUrl = "MANGO_MAILGUN_API_BASE_URL";

    public const string MangoMailgunApiDomain = "MANGO_MAILGUN_API_DOMAIN";

    public const string MangoJsonConfig = "appsettings.json";

    public static readonly Type MangoEnvConfigType = typeof(EnvironmentVariablesConfigurationProvider);

    public static readonly Type MangoJsonConfigType = typeof(JsonConfigurationProvider);
}
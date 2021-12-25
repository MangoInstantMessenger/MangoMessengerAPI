using System;

namespace MangoAPI.Domain.Constants
{
    public static class EnvironmentConstants
    {
        public static string MangoJwtIssuer => Environment.GetEnvironmentVariable("MANGO_JWT_ISSUER");

        public static string MangoJwtAudience => Environment.GetEnvironmentVariable("MANGO_JWT_AUDIENCE");

        public static string MangoJwtSignKey => Environment.GetEnvironmentVariable("MANGO_JWT_SIGN_KEY");

        public static string MangoJwtLifetime => Environment.GetEnvironmentVariable("MANGO_JWT_LIFETIME");

        public static string MangoRefreshTokenLifetime =>
            Environment.GetEnvironmentVariable("MANGO_REFRESH_TOKEN_LIFETIME");

        public static string MangoEmailNotificationsAddress =>
            Environment.GetEnvironmentVariable("MANGO_EMAIL_NOTIFICATIONS_ADDRESS");

        public static string MangoEmailNotificationsPassword =>
            Environment.GetEnvironmentVariable("MANGO_EMAIL_NOTIFICATIONS_PASSWORD");

        public static string MangoFrontendAddress => Environment.GetEnvironmentVariable("MANGO_FRONTEND_ADDRESS");

        public static string MangoBackendAddress => Environment.GetEnvironmentVariable("MANGO_BACKEND_ADDRESS");

        public static string MangoDatabaseUrl => Environment.GetEnvironmentVariable("MANGO_DATABASE_URL");

        public static string MangoSeedPassword => Environment.GetEnvironmentVariable("MANGO_SEED_PASSWORD");
    }
}
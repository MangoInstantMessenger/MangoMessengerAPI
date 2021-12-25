using System;

namespace MangoAPI.Domain.Constants
{
    public static class EnvironmentConstants
    {
        public static string MangoTokenKey => Environment.GetEnvironmentVariable("MANGO_JWT_SIGN_KEY");

        public static string MangoIssuer => Environment.GetEnvironmentVariable("MANGO_JWT_ISSUER");

        public static string MangoAudience => Environment.GetEnvironmentVariable("MANGO_JWT_AUDIENCE");

        public static string JwtLifeTime => Environment.GetEnvironmentVariable("MANGO_JWT_LIFETIME");

        public static string RefreshTokenLifeTime => Environment.GetEnvironmentVariable("MANGO_REFRESH_TOKEN_LIFETIME");

        public static string DbConnectionString => Environment.GetEnvironmentVariable("MANGO_DATABASE_URL");

        public static string EmailSenderAddress => Environment.GetEnvironmentVariable("MANGO_EMAIL_NOTIFICATIONS_ADDRESS");

        public static string EmailSenderPassword => Environment.GetEnvironmentVariable("MANGO_EMAIL_NOTIFICATIONS_PASSWORD");

        public static string FrontendAddress => Environment.GetEnvironmentVariable("MANGO_FRONTEND_ADDRESS");
        
        public static string BackendAddress => Environment.GetEnvironmentVariable("MANGO_BACKEND_ADDRESS");

        public static string SeedPassword => Environment.GetEnvironmentVariable("MANGO_SEED_PASSWORD");
    }
}

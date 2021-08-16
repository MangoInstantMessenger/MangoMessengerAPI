namespace MangoAPI.Application.Services
{
    public static class HerokuStringParser
    {
        public static string Convert(string databaseUrl)
        {
            if (string.IsNullOrEmpty(databaseUrl) || !databaseUrl.Contains("postgres")) return null;

            if (!databaseUrl.Contains(@"://")) return databaseUrl;

            var temp = databaseUrl.Split(@"://");
            var parameters = temp[1].Split(':', '@', '/');
            var connectionString =
                $"Server={parameters[2]};Port={parameters[3]};User Id={parameters[0]};Password={parameters[1]};Database={parameters[4]};sslmode=Require;Trust Server Certificate=true;";
            return connectionString;
        }
    }
}
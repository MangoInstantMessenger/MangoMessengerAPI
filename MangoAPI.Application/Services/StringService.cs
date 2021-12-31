using MangoAPI.Domain.Constants;

namespace MangoAPI.Application.Services
{
    public class StringService
    {
        public string ConvertHerokuDbConnection(string databaseUrl)
        {
            if (string.IsNullOrEmpty(databaseUrl) || !databaseUrl.Contains("postgres"))
            {
                return null;
            }

            if (!databaseUrl.Contains(@"://"))
            {
                return databaseUrl;
            }

            var temp = databaseUrl.Split(@"://");
            var parameters = temp[1].Split(':', '@', '/');
            var connectionString =
                $"Server={parameters[2]};Port={parameters[3]};User Id={parameters[0]};Password={parameters[1]};Database={parameters[4]};sslmode=Require;Trust Server Certificate=true;";
            return connectionString;
        }

        public string GetDocumentUrl(string fileName)
        {
            if (string.IsNullOrEmpty(fileName) || string.IsNullOrWhiteSpace(fileName))
            {
                return null;
            }

            return $"{EnvironmentConstants.MangoBlobAccess}/{fileName}";
        }
    }
}

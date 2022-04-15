using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using MangoAPI.Domain.Constants;

namespace MangoAPI.Application.Services;

public static class StringService
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public static string ConvertHerokuDbConnection(string databaseUrl)
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
            $"Server={parameters[2]};" +
            $"Port={parameters[3]};" +
            $"User Id={parameters[0]};" +
            $"Password={parameters[1]};" +
            $"Database={parameters[4]};" +
            "sslmode=Require;" +
            "Trust Server Certificate=true;";

        return connectionString;
    }

    public static string GetDocumentUrl(string fileName)
    {
        return string.IsNullOrWhiteSpace(fileName) ? null : $"{EnvironmentConstants.MangoBlobAccess}/{fileName}";
    }

    public static string GetUniqueFileName(string fileName)
    {
        fileName = Path.GetFileName(fileName);
        return Path.GetFileNameWithoutExtension(fileName)
               + "_"
               + Guid.NewGuid()
               + Path.GetExtension(fileName);
    }
}
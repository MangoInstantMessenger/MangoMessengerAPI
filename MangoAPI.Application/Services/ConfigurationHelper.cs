using Microsoft.Extensions.Configuration;
using System;

namespace MangoAPI.Application.Services;

public static class ConfigurationHelper
{
    /// <summary>
    /// This method is created as workaround for docker compose. Parameters in docker compose is better to pass via
    /// environment variables.
    /// </summary>
    public static string TryGetFromEnvironment(string key, IConfiguration configuration)
    {
        var value = Environment.GetEnvironmentVariable(key) ?? configuration[key];

        return value;
    }
}
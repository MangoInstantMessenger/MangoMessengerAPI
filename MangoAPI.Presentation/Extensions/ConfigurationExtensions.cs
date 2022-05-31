using System;
using System.Configuration;
using System.Linq;
using MangoAPI.Domain.Constants;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.EnvironmentVariables;
using Microsoft.Extensions.Configuration.Json;

namespace MangoAPI.Presentation.Extensions;

public static class ConfigurationExtensions
{
    public static string GetValueFromAppSettingsOrEnvironment(this IConfiguration configuration, string key)
    {
        var mangoEnvConfigType = typeof(EnvironmentVariablesConfigurationProvider);
        var mangoJsonConfigType = typeof(JsonConfigurationProvider);

        if (configuration is not IConfigurationRoot configurationRoot)
        {
            throw new ArgumentNullException(nameof(configuration));
        }

        var jsonConfigProvider = configurationRoot.Providers.FirstOrDefault(t =>
            t.GetType() == mangoJsonConfigType &&
            t.ToString()!.Contains(EnvironmentConstants.MangoJsonConfig));

        if (jsonConfigProvider != null
            && jsonConfigProvider.TryGet(key, out var jsonData)
            && !string.IsNullOrEmpty(jsonData))
        {
            return jsonData;
        }

        var environmentProvider = configurationRoot.Providers.FirstOrDefault(t =>
            t.GetType() == mangoEnvConfigType);

        if (environmentProvider != null
            && environmentProvider.TryGet(key, out var envData)
            && !string.IsNullOrEmpty(envData))
        {
            return envData;
        }

        throw new ConfigurationErrorsException($"Cannot find a key - {key}");
    }
}
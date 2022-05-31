using System;
using System.Configuration;
using System.Linq;
using MangoAPI.Presentation.Constants;
using Microsoft.Extensions.Configuration;

namespace MangoAPI.Presentation.Extensions;

public static class ConfigurationExtensions
{
    public static string GetValueFromAppSettingsOrEnvironment(this IConfiguration configuration, string key)
    {
        if (configuration is not IConfigurationRoot configurationRoot)
        {
            throw new ArgumentNullException(nameof(configuration));
        }

        var jsonConfigProvider = configurationRoot.Providers.FirstOrDefault(t =>
            t.GetType() == EnvironmentConstants.MangoJsonConfigType &&
            t.ToString()!.Contains(EnvironmentConstants.MangoJsonConfig));

        if (jsonConfigProvider != null
            && jsonConfigProvider.TryGet(key, out var jsonData)
            && !string.IsNullOrEmpty(jsonData))
        {
            return jsonData;
        }

        var environmentProvider = configurationRoot.Providers.FirstOrDefault(t =>
            t.GetType() == EnvironmentConstants.MangoEnvConfigType);

        if (environmentProvider != null
            && environmentProvider.TryGet(key, out var envData)
            && !string.IsNullOrEmpty(envData))
        {
            return envData;
        }

        throw new ConfigurationErrorsException($"Cannot find a key - {key}");
    }
}
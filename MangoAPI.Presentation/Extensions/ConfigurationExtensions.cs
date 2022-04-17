using System;
using System.Configuration;
using System.Linq;
using MangoAPI.Presentation.Constants;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using ConfigurationSection = System.Configuration.ConfigurationSection;

namespace MangoAPI.Presentation.Extensions;

public static class ConfigurationExtensions
{
    public static string GetValueFromAppSettingsOrEnvironment(this IConfiguration configuration, string key)
    {
        if (configuration is not IConfigurationRoot configurationRoot)
        {
            throw new ArgumentNullException(nameof(configurationRoot));
        }
        
        var jsonConfigProvider = configurationRoot.Providers.FirstOrDefault(t => 
            t.GetType() == EnvironmentConstants.MangoJsonConfigType && t.ToString()!.Contains(EnvironmentConstants.MangoJsonConfig));

        if (jsonConfigProvider != null && jsonConfigProvider.TryGet(key, out var jsonData))
        {
            return jsonData;
        }
        
        var environmentProvider = configurationRoot.Providers.FirstOrDefault(t => 
            t.GetType() == EnvironmentConstants.MangoEnvConfigType);
        
        if (environmentProvider != null && environmentProvider.TryGet(key, out var envData))
        {
            return envData;
        }

        throw new ConfigurationErrorsException($"Cannot find a key - {key}");
    }
}
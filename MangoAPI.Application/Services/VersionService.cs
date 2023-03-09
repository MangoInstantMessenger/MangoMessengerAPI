using MangoAPI.Application.Interfaces;
using System.Reflection;

namespace MangoAPI.Application.Services;

public class VersionService : IVersionService
{
    public const string DefaultVersion = "1.0.0.0";

    public string GetVersion()
    {
        var version = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? DefaultVersion;

        return version;
    }
}
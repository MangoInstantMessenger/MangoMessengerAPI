using System;
using System.IO;

namespace MangoAPI.Application.Services;

public static class AppSettingsService
{
    private const string AppSettingsPath = "../../../../MangoAPI.Presentation/appsettings.json";

    public static string GetAppSettingsPath()
    {
        var path = Path.Combine(AppContext.BaseDirectory, AppSettingsPath);
        return path;
    }
}
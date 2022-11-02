using System;
using System.IO;

namespace MangoAPI.Application.Services;

public static class AppSettingsService
{
    private const string AppSettingsPath = "../../../../Messenger.WebApi/appsettings.json";

    public static string GetAppSettingsPath()
    {
        var path = Path.Combine(AppContext.BaseDirectory, AppSettingsPath);
        return path;
    }
}

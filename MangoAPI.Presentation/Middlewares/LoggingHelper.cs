using Microsoft.Extensions.Logging;
using System;

namespace MangoAPI.Presentation.Middlewares;

public static class LoggingHelper
{
    public static readonly Action<ILogger, string, Exception> LoggerError =
        LoggerMessage.Define<string>(LogLevel.Error, eventId:
            new EventId(id: 0, name: "ERROR"), formatString: "{Message}");

    public static readonly Action<ILogger, string, Exception> LoggerWarning =
        LoggerMessage.Define<string>(LogLevel.Warning, eventId:
            new EventId(id: 0, name: "WARNING"), formatString: "{Message}");

    public static readonly Action<ILogger, string, Exception> LoggerInformation =
        LoggerMessage.Define<string>(LogLevel.Information, eventId:
            new EventId(id: 0, name: "INFORMATION"), formatString: "{Message}");
}
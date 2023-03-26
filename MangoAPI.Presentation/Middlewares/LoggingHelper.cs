using Microsoft.Extensions.Logging;
using System;

namespace MangoAPI.Presentation.Middlewares;

public static class LoggingHelper
{
    public static readonly Action<ILogger, string, Exception> LoggerError =
        LoggerMessage.Define<string>(LogLevel.Error, new EventId(0, "ERROR"), "{Message}");

    public static readonly Action<ILogger, string, Exception> LoggerWarning =
        LoggerMessage.Define<string>(LogLevel.Warning, new EventId(0, "WARNING"), "{Message}");

    public static readonly Action<ILogger, string, Exception> LoggerInformation =
        LoggerMessage.Define<string>(LogLevel.Information, new EventId(0, "INFORMATION"), "{Message}");
}
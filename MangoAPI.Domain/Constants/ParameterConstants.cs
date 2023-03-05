using System.Reflection;

namespace MangoAPI.Domain.Constants;

public static class ParameterConstants
{
    public static string GetVersionParameter()
    {
        return Assembly.GetExecutingAssembly().GetName().Version?.ToString();
    }
}
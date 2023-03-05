using MangoAPI.Application.Interfaces;
using System.Reflection;

namespace MangoAPI.Application.Services;

public class ParameterService : IParameterService
{
    public string GetVersionParameter()
    {
        return Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "1.0.0.0";
    }
}
using System;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.BusinessLogic.Configuration;

public static class MangoCompositionRoot
{
    public static IServiceProvider Provider { get; set; }

    public static void SetProvider(IServiceProvider provider)
    {
        Provider = provider;
    }

    public static IServiceScope CreateScope()
    {
        var scope = Provider.CreateScope();
        return scope;
    }
}
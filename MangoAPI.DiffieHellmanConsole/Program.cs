using System;
using System.Threading.Tasks;
using MangoAPI.DiffieHellmanConsole.Controllers;

namespace MangoAPI.DiffieHellmanConsole;

public static class Program
{
    public static async Task Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine(@"Unrecognized command.");
            return;
        }

        var method = args[0];

        switch (FetchMethodName(args[0]))
        {
            case "openssl":
                await OpenSslController.FetchOpenSslHandler(args, method);
                break;
            case "cng":
                await CngController.FetchCngHandler(args, method);
                break;
            case "auth":
                await AuthController.FetchAuthHandler(args, method);
                break;
        }
    }

    private static string FetchMethodName(string method)
    {
        if (method.StartsWith("openssl"))
        {
            return "openssl";
        }

        if (method.StartsWith("cng"))
        {
            return "cng";
        }

        return "auth";
    }
}
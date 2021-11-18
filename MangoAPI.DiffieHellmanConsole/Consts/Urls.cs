using System;

namespace MangoAPI.DiffieHellmanConsole.Consts
{
    public static class Urls
    {
        public static readonly string ApiUrl = Environment.GetEnvironmentVariable("AZURE_BACKEND_URL");
    }
}
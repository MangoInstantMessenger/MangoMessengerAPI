namespace MangoAPI.DiffieHellmanLibrary.Consts;

public static class Routes
{
    public static string ApiAddress => GetApiBaseUrl();

    private static string GetApiBaseUrl()
    {
        var baseUrl = Environment.GetEnvironmentVariable("MANGO_API_ADDRESS");

        if (!string.IsNullOrEmpty(baseUrl))
        {
            return baseUrl;
        }

        Console.WriteLine(
            @"MANGO_API_ADDRESS environment variable is not set. Using default value: https://localhost:5001/api/");

        return "https://localhost:5001/api/";
    }
}
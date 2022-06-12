namespace MangoAPI.DiffieHellmanLibrary.Constants;

public static class KeyExchangeRoutes
{
    public static string Parameters => Routes.ApiAddress + "key-exchange-requests/parameters";

    public static string KeyExchangeRequests => Routes.ApiAddress + "key-exchange-requests";

    public static string PublicKeys => Routes.ApiAddress + "key-exchange-requests/public-keys";
}
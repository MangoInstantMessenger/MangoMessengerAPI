namespace MangoAPI.DiffieHellmanLibrary.Constants;

public static class OpenSslRoutes
{
    public static string OpenSslParameters => Routes.ApiAddress + "key-exchange-requests/parameters";

    public static string OpenSslKeyExchangeRequests => Routes.ApiAddress + "key-exchange-requests";

    public static string OpenSslPublicKeys => Routes.ApiAddress + "key-exchange-requests/public-keys";
}
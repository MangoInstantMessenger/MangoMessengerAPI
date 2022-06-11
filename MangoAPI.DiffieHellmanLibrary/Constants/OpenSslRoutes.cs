namespace MangoAPI.DiffieHellmanLibrary.Constants;

public static class OpenSslRoutes
{
    public static string OpenSslParameters => Routes.ApiAddress + "openssl-key-exchange-requests/openssl-parameters";

    public static string OpenSslKeyExchangeRequests => Routes.ApiAddress + "openssl-key-exchange-requests";

    public static string OpenSslPublicKeys => Routes.ApiAddress + "openssl-key-exchange-requests/public-keys";
}
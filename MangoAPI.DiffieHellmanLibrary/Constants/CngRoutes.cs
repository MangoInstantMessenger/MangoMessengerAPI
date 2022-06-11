namespace MangoAPI.DiffieHellmanLibrary.Constants;

public static class CngRoutes
{
    public static string CngPublicKeys => Routes.ApiAddress + "cng-public-keys";
    
    public static string CngKeyExchangeRequests => Routes.ApiAddress + "cng-key-exchange-requests";
}
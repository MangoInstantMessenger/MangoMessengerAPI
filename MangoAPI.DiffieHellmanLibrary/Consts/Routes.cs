namespace MangoAPI.DiffieHellmanLibrary.Consts;

public static class Routes
{
    //private const string ApiDomain = "https://back.mangomessenger.company/api/";
    private const string ApiDomain = "https://localhost:5001/api/";
    public const string SessionsRoute = ApiDomain + "sessions/";
    
    public const string CngPublicKeys = ApiDomain + "public-keys/cng-public-keys";
    public const string CngKeyExchangeRequests = ApiDomain + "key-exchange/cng-key-exchange-requests";
    
    public const string OpenSslParameters = ApiDomain + "key-exchange/openssl-parameters";
    public const string OpenSslKeyExchangeRequests = ApiDomain + "key-exchange/openssl-key-exchange-requests";
}
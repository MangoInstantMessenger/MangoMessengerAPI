namespace MangoAPI.DiffieHellmanConsole.Consts;

public static class Routes
{
    //private const string ApiDomain = "https://back.mangomessenger.company/api/";
    private const string ApiDomain = "https://localhost:5001/api/";
    public const string ApiPublicKeysCngPublicKeys = ApiDomain + "cng-public-keys";
    public const string SessionsRoute = ApiDomain + "sessions/";
    public const string ApiKeyExchangeOpenSslParameters = ApiDomain + "key-exchange/openssl-parameters";
    public const string ApiKeyExchangeCngKeyExchangeRequests = ApiDomain + "key-exchange/cng-key-exchange-requests";
}
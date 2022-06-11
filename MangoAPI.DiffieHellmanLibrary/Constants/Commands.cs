namespace MangoAPI.DiffieHellmanLibrary.Constants;

public static class Commands
{
    public const string Login = "login";
    public const string RefreshToken = "refresh-token";
    
    public const string CngGeneratePrivateKey = "cng-generate-private-key";
    public const string CngCreateKeyExchange = "cng-create-key-exchange";
    public const string CngPrintKeyExchanges = "cng-print-key-exchanges";
    public const string CngConfirmKeyExchange = "cng-confirm-key-exchange";
    public const string CngPrintPublicKeys = "cng-print-public-keys";
    public const string CngCreateCommonSecret = "cng-create-common-secret";
    
    public const string OpenSslGenerateDhParameters = "openssl-generate-dh-parameters";
    public const string OpenSslUploadDhParameters = "openssl-upload-dh-parameters";
    public const string OpenSslDownloadDhParameters = "openssl-download-dh-parameters";
    public const string OpenSslGeneratePrivateKey = "openssl-generate-private-key";
    public const string OpenSslGeneratePublicKey = "openssl-generate-public-key";
    public const string OpenSslCreateKeyExchange = "openssl-create-key-exchange";
    public const string OpenSslPrintKeyExchanges = "openssl-print-key-exchanges";
    public const string OpenSslConfirmKeyExchange = "openssl-confirm-key-exchange";
    public const string OpenSslCreateCommonSecret = "openssl-create-common-secret";
    public const string OpenSslDownloadPublicKey = "openssl-download-public-key";
    public const string OpenSslDeclineKeyExchange = "openssl-decline-key-exchange";
    public const string OpenSslPrintKeyExchangeById = "openssl-print-key-exchange";
    public const string OpensslValidateCommonSecret = "openssl-validate-common-secret";
}
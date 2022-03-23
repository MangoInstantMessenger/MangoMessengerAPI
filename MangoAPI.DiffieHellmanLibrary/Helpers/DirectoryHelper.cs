namespace MangoAPI.DiffieHellmanLibrary.Helpers;

public static class DirectoryHelper
{
    private static string OpenSslWorkingDirectory => Path.Combine(AppContext.BaseDirectory, @"..\..\..\OpenSsl");
    public static string OpenSslPublicKeysDirectory => Path.Combine(OpenSslWorkingDirectory, @"OpenSslPublicKeys");
    public static string OpenSslPrivateKeysDirectory => Path.Combine(OpenSslWorkingDirectory, @"OpenSslPrivateKeys");
    public static string OpenSslCommonSecretsDirectory => Path.Combine(OpenSslWorkingDirectory, @"OpenSslCommonSecrets");
    public static string OpenSslDhParametersDirectory => Path.Combine(OpenSslWorkingDirectory, @"OpenSslDhParameters");
}
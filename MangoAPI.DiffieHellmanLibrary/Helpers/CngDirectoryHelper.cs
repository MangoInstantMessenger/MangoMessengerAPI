namespace MangoAPI.DiffieHellmanLibrary.Helpers;

public static class CngDirectoryHelper
{
    public static string CngPublicKeysDirectory => Path.Combine(CngWorkingDirectory, @"CngPublicKeys");

    public static string CngPrivateKeysDirectory => Path.Combine(CngWorkingDirectory, @"CngPrivateKeys");

    public static string CngCommonSecretsDirectory => Path.Combine(CngWorkingDirectory, @"CngCommonSecrets");

    private static string CngWorkingDirectory =>
        Path.Combine(AppContext.BaseDirectory, @"..\..\..\CngWorkingDirectory");
}

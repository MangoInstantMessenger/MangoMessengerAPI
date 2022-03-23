namespace MangoAPI.DiffieHellmanLibrary.Helpers;

public static class AuthDirectoryHelper
{
    public static string AuthWorkingDirectory =>
        Path.Combine(AppContext.BaseDirectory, @"..\..\..\AuthWorkingDirectory");
}
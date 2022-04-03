namespace MangoAPI.DiffieHellmanLibrary.Extensions;

public static class DirectoryExtensions
{
    public static void CreateDirectoryIfNotExist(this string path)
    {
        if (path == null)
        {
            throw new ArgumentNullException(nameof(path));
        }

        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
    }
}
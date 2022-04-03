namespace MangoAPI.DiffieHellmanLibrary.Helpers;

public static class FileNameHelper
{
    public const string ParametersFileName = "DHP.pem";

    public const string DownloadedParametersFileName = "DOWNLOADED_DHP.pem";

    public static string GeneratePrivateKeyFileName(Guid senderId, Guid receiverId)
    {
        var fileName = $"OPENSSL_PRIVATE_KEY_{senderId}_{receiverId}.pem";
        return fileName;
    }

    public static string GeneratePublicKeyFileName(Guid senderId, Guid receiverId)
    {
        var fileName = $"OPENSSL_PUBLIC_KEY_{senderId}_{receiverId}.pem";
        return fileName;
    }

    public static string GenerateCommonSecretFileName(Guid senderId, Guid receiverId)
    {
        var fileName = $"OPENSSL_COMMON_SECRET_{senderId}_{receiverId}.pem";
        return fileName;
    }
}
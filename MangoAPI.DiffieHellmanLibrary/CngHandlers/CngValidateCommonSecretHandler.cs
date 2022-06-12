using System.Security.Cryptography;
using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngValidateCommonSecretHandler : BaseHandler, IValidateCommonSecretHandler
{
    public CngValidateCommonSecretHandler(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task ValidateCommonSecretAsync(Guid senderId, Guid receiverId)
    {
        Console.WriteLine($@"Validating common secrets for {senderId} and {receiverId} ...");

        var result = await ValidateAsync(senderId, receiverId);

        Console.WriteLine(@$"Sender Hash: {result.SenderHash}");
        Console.WriteLine(@$"Receiver Hash: {result.ReceiverHash}");

        var hashesEqual = result.SenderHash == result.ReceiverHash;

        Console.WriteLine($@"Are hashes equal? {hashesEqual}");
        Console.WriteLine();
    }

    private static async Task<HashResult> ValidateAsync(
        Guid senderId,
        Guid receiverId)
    {
        var commonSecretDirectory = CngDirectoryHelper.CngCommonSecretsDirectory;
        var senderCommonSecretFileName = FileNameHelper.GenerateCngCommonSecretFileName(senderId, receiverId);
        var receiverCommonSecretFileName = FileNameHelper.GenerateCngCommonSecretFileName(receiverId, senderId);


        var senderPath = Path.Combine(commonSecretDirectory, senderCommonSecretFileName);
        var receiverPath = Path.Combine(commonSecretDirectory, receiverCommonSecretFileName);

        var key = RandomNumberGenerator.GetBytes(128);

        var senderHash = await ComputeHashAsync(key, senderPath);
        var receiverHash = await ComputeHashAsync(key, receiverPath);

        var result = new HashResult(senderHash, receiverHash);

        return result;
    }

    private static async Task<string> ComputeHashAsync(byte[] key, string path)
    {
        using var md5 = new HMACSHA512(key);
        await using var senderStream = File.OpenRead(path);
        var hashBytes = await md5.ComputeHashAsync(senderStream);
        var hashAsString = Convert.ToBase64String(hashBytes);

        return hashAsString;
    }
}
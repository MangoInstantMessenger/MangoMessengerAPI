using System.Security.Cryptography;
using MangoAPI.DiffieHellmanLibrary.Extensions;

namespace MangoAPI.DiffieHellmanLibrary.Helpers;

public static class CngEcdhHelper
{
    public static EccDhKeyPair GenerateEcdhBase64StringPrivateKey()
    {
        var parameters = new CngKeyCreationParameters
        {
            ExportPolicy = CngExportPolicies.AllowPlaintextExport,
        };

        var keys = CngKey.Create(CngAlgorithm.ECDiffieHellmanP256, null, parameters);

        var ecDiffieHellmanCng = new ECDiffieHellmanCng(keys);

        var privateKeyBase64String = ecDiffieHellmanCng.Key.Export(CngKeyBlobFormat.EccPrivateBlob).AsBase64String();

        var publicKeyBase64String = ecDiffieHellmanCng.PublicKey.ToByteArray().AsBase64String();

        var result = new EccDhKeyPair(privateKeyBase64String, publicKeyBase64String);

        return result;
    }
}

#pragma warning disable SA1313
public record EccDhKeyPair(string PrivateKey, string PublicKey);
#pragma warning restore SA1313

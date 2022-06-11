using System.Security.Cryptography;
using MangoAPI.DiffieHellmanLibrary.Extensions;

namespace MangoAPI.DiffieHellmanLibrary.Helpers;

public static class CngEcdhHelper
{
    public static ECDiffieHellmanCng CngGenerateEcdhKeysPair(out string privateKeyBase64, out string publicKeyBase64)
    {
#pragma warning disable CA1416
        var parameters = new CngKeyCreationParameters
        {
            ExportPolicy = CngExportPolicies.AllowPlaintextExport
        };
#pragma warning restore CA1416

#pragma warning disable CA1416
        var keys = CngKey.Create(CngAlgorithm.ECDiffieHellmanP256, null, parameters);
#pragma warning restore CA1416

#pragma warning disable CA1416
        var ecDiffieHellmanCng = new ECDiffieHellmanCng(keys);
#pragma warning restore CA1416

#pragma warning disable CA1416
        privateKeyBase64 = ecDiffieHellmanCng.Key.Export(CngKeyBlobFormat.EccPrivateBlob).AsBase64String();
#pragma warning restore CA1416

#pragma warning disable CA1416
        publicKeyBase64 = ecDiffieHellmanCng.PublicKey.ToByteArray().AsBase64String();
#pragma warning restore CA1416

        return ecDiffieHellmanCng;
    }
}
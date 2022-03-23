using System.Security.Cryptography;
using MangoAPI.DiffieHellmanLibrary.Extensions;

namespace MangoAPI.DiffieHellmanLibrary.Services;

public class CngEcdhService
{
    public ECDiffieHellmanCng CngGenerateEcdhKeysPair(out string privateKeyBase64, out string publicKeyBase64)
    {
        var parameters = new CngKeyCreationParameters
        {
            ExportPolicy = CngExportPolicies.AllowPlaintextExport
        };

        var keys = CngKey.Create(CngAlgorithm.ECDiffieHellmanP256, null, parameters);

        var ecDiffieHellmanCng = new ECDiffieHellmanCng(keys);

        privateKeyBase64 = ecDiffieHellmanCng.Key.Export(CngKeyBlobFormat.EccPrivateBlob).AsBase64String();
        publicKeyBase64 = ecDiffieHellmanCng.PublicKey.ToByteArray().AsBase64String();

        return ecDiffieHellmanCng;
    }
}
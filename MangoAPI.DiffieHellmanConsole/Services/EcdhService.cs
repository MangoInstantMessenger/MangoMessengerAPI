using System.Security.Cryptography;
using MangoAPI.DiffieHellmanConsole.Extensions;

namespace MangoAPI.DiffieHellmanConsole.Services
{
    public static class EcdhService
    {
        public static ECDiffieHellmanCng GenerateEcdhKeysPair(out string privateKeyBase64, out string publicKeyBase64)
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
}
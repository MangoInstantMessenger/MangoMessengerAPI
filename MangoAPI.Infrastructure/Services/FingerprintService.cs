using CryptHash.Net.Hash.Hash;
using MangoAPI.Application.Common;
using MangoAPI.Application.Services;

namespace MangoAPI.Infrastructure.Services
{
    public class FingerprintService : IFingerprintService
    {
        public string GetFingerprint(RequestMetadata requestMetadata)
            => new SHA256().ComputeHash(GetHashtableString(requestMetadata)).HashString;

        public bool VerifyFingerPrint(RequestMetadata metadata, string fingerPrint)
            => new SHA256().VerifyHash(fingerPrint, GetHashtableString(metadata)).Success;

        private static string GetHashtableString(RequestMetadata requestMetadata)
            => $"{requestMetadata.IpAddress}{requestMetadata.UserAgent}{requestMetadata.FingerPrintSalt}";
    }
}
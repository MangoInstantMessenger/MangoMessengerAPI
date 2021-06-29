using MangoAPI.Application.Common;

namespace MangoAPI.Application.Services
{
    public interface IFingerprintService
    {
        public string GetFingerprint(RequestMetadata requestMetadata);
        public bool VerifyFingerPrint(RequestMetadata metadata, string fingerPrint);
    }
}
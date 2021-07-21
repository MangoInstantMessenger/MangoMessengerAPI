namespace MangoAPI.Application.Common
{
    public class RequestMetadata
    {
        public string UserAgent { get; set; }
        public string FingerPrintSalt { get; set; }
        public string UserId { get; set; }
    }
}
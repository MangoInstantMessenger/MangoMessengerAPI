namespace MangoAPI.Application.Common
{
    public class RequestMetadata
    {
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
        public string FingerPrintSalt { get; set; }
    }
}
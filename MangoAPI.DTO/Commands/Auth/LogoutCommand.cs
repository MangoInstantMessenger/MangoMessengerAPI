namespace MangoAPI.DTO.Commands.Auth
{
    public class LogoutCommand
    {
        public string RefreshTokenId { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
        public string FingerPrint { get; set; }
    }
}
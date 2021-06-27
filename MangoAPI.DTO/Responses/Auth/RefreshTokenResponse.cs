namespace MangoAPI.DTO.Responses.Auth
{
    public class RefreshTokenResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public string RefreshTokenId { get; set; }
        public string AccessToken { get; set; }
    }
}
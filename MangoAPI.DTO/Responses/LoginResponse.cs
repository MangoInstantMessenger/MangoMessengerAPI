namespace MangoAPI.DTO.Responses
{
    public class LoginResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
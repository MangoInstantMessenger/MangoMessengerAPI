namespace MangoAPI.DTO.Responses
{
    public class ConfirmRegisterResponse
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}
namespace MangoAPI.DTO.Responses.Auth
{
    public record LogoutResponse
    {
        public bool Success { get; init; } 
        public string Message { get; init; }

        public static LogoutResponse RefreshTokenNotFoundResponse => new()
        {
            Success = false,
            Message = "Refresh token was not found"
        };
        
        public static LogoutResponse RefreshTokenNotValidated => new()
        {
            Success = false,
            Message = "Refresh token was not validated"
        };
        
        public static LogoutResponse SuspiciousLogout => new()
        {
            Success = false,
            Message = "Logout attempt is suspicious"
        };
        
        public static LogoutResponse SuccessResponse => new()
        {
            Success = true,
            Message = "Success"
        };
    }
}
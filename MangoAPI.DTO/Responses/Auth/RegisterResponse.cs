namespace MangoAPI.DTO.Responses.Auth
{
    public class RegisterResponse
    {
        public string Message { get; set; }
        public bool TermsAccepted { get; set; }
        public bool AlreadyRegistered { get; set; }
    }
}
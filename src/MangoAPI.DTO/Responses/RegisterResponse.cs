namespace MangoAPI.DTO.Responses
{
    public class RegisterResponse
    {
        public string Message { get; set; }
        public bool TermsAccepted { get; set; }
        public bool AlreadyRegistered { get; set; }
    }
}
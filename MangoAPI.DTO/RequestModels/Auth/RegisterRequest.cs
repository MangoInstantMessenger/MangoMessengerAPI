using MangoAPI.DTO.ApiCommands.Auth;
using MangoAPI.DTO.Enums;

namespace MangoAPI.DTO.RequestModels.Auth
{
    public record RegisterRequest
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public VerificationMethod VerificationMethod { get; set; }
        public bool TermsAccepted { get; set; }
    }

    public static class RegisterCommandMapper
    {
        public static RegisterCommand ToCommand(this RegisterRequest model) =>
            new()
            {
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
                DisplayName = model.DisplayName,
                Password = model.Password,
                VerificationMethod = model.VerificationMethod,
                TermsAccepted = model.TermsAccepted
            };
    }
}
using MangoAPI.DTO.Enums;
using MangoAPI.DTO.Responses.Auth;
using MediatR;

namespace MangoAPI.DTO.Commands.Auth
{
    public class RegisterCommand : IRequest<RegisterResponse>
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public VerificationMethod VerificationMethod { get; set; }
        public bool TermsAccepted { get; set; }
    }
}
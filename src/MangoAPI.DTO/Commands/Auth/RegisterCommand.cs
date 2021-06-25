using MangoAPI.DTO.Responses;
using MediatR;

namespace MangoAPI.DTO.Commands.Auth
{
    public class RegisterCommand : IRequest<RegisterResponse>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool TermsAccepted { get; set; }
    }
}
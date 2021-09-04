using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Enums;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record RegisterCommand : IRequest<TokensResponse>
    {
        public string PhoneNumber { get; init; }
        public string Email { get; init; }
        public string DisplayName { get; init; }
        public string Password { get; init; }
        public VerificationMethod VerificationMethod { get; init; }
        public bool TermsAccepted { get; init; }
    }
}
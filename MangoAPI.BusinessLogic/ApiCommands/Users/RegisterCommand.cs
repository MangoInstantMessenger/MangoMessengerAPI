namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    using Enums;
    using MediatR;

    public record RegisterCommand : IRequest<RegisterResponse>
    {
        public string PhoneNumber { get; init; }
        public string Email { get; init; }
        public string DisplayName { get; init; }
        public string Password { get; init; }
        public VerificationMethod VerificationMethod { get; init; }
        public bool TermsAccepted { get; init; }
    }
}

using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record RegisterCommand : IRequest<Result<TokensResponse>>
    {
        public string Email { get; init; }
        public string DisplayName { get; init; }
        public string Password { get; init; }
        public bool TermsAccepted { get; init; }
    }
}
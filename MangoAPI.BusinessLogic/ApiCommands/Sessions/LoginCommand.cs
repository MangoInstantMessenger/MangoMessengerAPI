using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Enums;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public record LoginCommand : IRequest<TokensResponse>
    {
        public string Credential { get; init; }
        public VerificationMethod VerificationMethod { get; set; }
        public string Password { get; init; }
    }
}

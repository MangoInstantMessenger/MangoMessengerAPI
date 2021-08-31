using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public record LoginCommand : IRequest<TokensResponse>
    {
        public string Email { get; init; }
        public string Password { get; init; }
    }
}

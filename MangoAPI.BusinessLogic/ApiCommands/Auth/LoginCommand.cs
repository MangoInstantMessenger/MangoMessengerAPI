using MangoAPI.BusinessLogic.Responses.Auth;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Auth
{
    public record LoginCommand : IRequest<LoginResponse>
    {
        public string Email { get; init; }
        public string Password { get; init; }
    }
}
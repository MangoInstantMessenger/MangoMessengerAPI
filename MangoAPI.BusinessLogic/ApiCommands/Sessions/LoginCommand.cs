using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public record LoginCommand : IRequest<LoginResponse>
    {
        public string Email { get; init; }
        public string Password { get; init; }
    }
}

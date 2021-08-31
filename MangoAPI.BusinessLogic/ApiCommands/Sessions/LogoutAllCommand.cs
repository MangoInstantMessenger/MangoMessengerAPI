using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public record LogoutAllCommand : IRequest<LogoutResponse>
    {
        public string UserId { get; init; }
    }
}

using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public record LogoutAllCommand : IRequest<LogoutResponse>
    {
        public string RefreshToken { get; init; }
        public string UserId { get; init; }
    }
}
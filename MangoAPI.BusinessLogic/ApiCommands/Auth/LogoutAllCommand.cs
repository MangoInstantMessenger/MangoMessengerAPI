using MangoAPI.BusinessLogic.Responses.Auth;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Auth
{
    public record LogoutAllCommand : IRequest<LogoutResponse>
    {
        public string SessionId { get; init; }
        public string UserId { get; init; }
    }
}
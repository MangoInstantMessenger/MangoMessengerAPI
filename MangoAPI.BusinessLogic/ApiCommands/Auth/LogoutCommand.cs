using MangoAPI.BusinessLogic.Responses.Auth;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Auth
{
    public record LogoutCommand : IRequest<LogoutResponse>
    {
        public string SessionId { get; init; }
    }
}
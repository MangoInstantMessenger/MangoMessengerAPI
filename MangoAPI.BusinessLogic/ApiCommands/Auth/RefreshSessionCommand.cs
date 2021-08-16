using MangoAPI.BusinessLogic.Responses.Auth;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Auth
{
    public record RefreshSessionCommand : IRequest<RefreshSessionResponse>
    {
        public string SessionId { get; init; }
    }
}
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public record RefreshSessionCommand : IRequest<RefreshSessionResponse>
    {
        public string RefreshToken { get; init; }
    }
}
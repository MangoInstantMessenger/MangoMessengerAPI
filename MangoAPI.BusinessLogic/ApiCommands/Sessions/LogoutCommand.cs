using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public record LogoutCommand : IRequest<LogoutResponse>
    {
        public string RefreshToken { get; init; }
    }
}
using MangoAPI.BusinessLogic.Responses.Auth;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Auth
{
    public record RefreshTokenCommand : IRequest<RefreshTokenResponse>
    {
        public string RefreshTokenId { get; init; }
    }
}
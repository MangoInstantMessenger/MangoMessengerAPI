using MangoAPI.DTO.Responses.Auth;
using MediatR;

namespace MangoAPI.DTO.ApiCommands.Auth
{
    public record LogoutCommand : IRequest<LogoutResponse>
    {
        public string RefreshTokenId { get; init; }
    }
}
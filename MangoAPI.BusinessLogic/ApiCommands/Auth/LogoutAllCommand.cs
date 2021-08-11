using MangoAPI.DTO.Responses.Auth;
using MediatR;

namespace MangoAPI.DTO.ApiCommands.Auth
{
    public record LogoutAllCommand : IRequest<LogoutResponse>
    {
        public string RefreshTokenId { get; init; }
        public string UserId { get; init; }
    }
}
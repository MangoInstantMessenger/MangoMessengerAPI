using MangoAPI.DTO.Responses.Auth;
using MediatR;

namespace MangoAPI.DTO.ApiCommands.Auth
{
    public record RefreshTokenCommand : IRequest<RefreshTokenResponse>
    {
        public string RefreshTokenId { get; set; }
    }
}
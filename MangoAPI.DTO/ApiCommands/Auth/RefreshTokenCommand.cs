using MangoAPI.DTO.Responses.Auth;
using MediatR;

namespace MangoAPI.DTO.ApiCommands.Auth
{
    public class RefreshTokenCommand : IRequest<RefreshTokenResponse>
    {
        public string RefreshTokenId { get; set; }
    }
}
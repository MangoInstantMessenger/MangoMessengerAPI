using MangoAPI.DTO.Responses.Auth;
using MediatR;

namespace MangoAPI.DTO.Commands.Auth
{
    public class LogoutAllCommand : IRequest<LogoutResponse>
    {
        public string RefreshTokenId { get; set; }
    }
}
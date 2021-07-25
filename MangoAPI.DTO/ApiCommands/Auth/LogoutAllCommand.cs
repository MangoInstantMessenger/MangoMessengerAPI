using MangoAPI.DTO.Responses.Auth;
using MediatR;

namespace MangoAPI.DTO.ApiCommands.Auth
{
    public class LogoutAllCommand : IRequest<LogoutResponse>
    {
        public string RefreshTokenId { get; set; }
        public string UserId { get; set; }
    }
}
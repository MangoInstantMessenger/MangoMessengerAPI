using MangoAPI.DTO.Responses.Auth;
using MediatR;

namespace MangoAPI.DTO.ApiCommands.Auth
{
    public class LogoutCommand : IRequest<LogoutResponse>
    {
        public string RefreshTokenId { get; set; }
    }
}
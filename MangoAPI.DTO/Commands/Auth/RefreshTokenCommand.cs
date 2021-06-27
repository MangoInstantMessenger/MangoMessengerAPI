using MangoAPI.DTO.Responses.Auth;
using MediatR;

namespace MangoAPI.DTO.Commands.Auth
{
    public class RefreshTokenCommand : IRequest<RefreshTokenResponse>
    {
        public string RefreshTokenId { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
        public string FingerPrint { get; set; }
    }
}
using MangoAPI.DTO.Responses.Auth;
using MediatR;

namespace MangoAPI.DTO.Commands.Auth
{
    public record LogoutCommand(
        string RefreshTokenId,
        string IpAddress,
        string UserAgent,
        string FingerPrint
    ) : IRequest<LogoutResponse>;
}
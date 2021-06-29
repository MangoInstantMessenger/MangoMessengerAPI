using MangoAPI.DTO.Responses.Auth;
using MediatR;

namespace MangoAPI.DTO.Commands.Auth
{
    public class RefreshTokenCommand : IRequest<RefreshTokenResponse>
    {
    }
}
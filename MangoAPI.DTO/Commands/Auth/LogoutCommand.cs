using MangoAPI.DTO.Common;
using MangoAPI.DTO.Responses.Auth;
using MediatR;

namespace MangoAPI.DTO.Commands.Auth
{
    public record LogoutCommand(
        string RefreshTokenId,
        RequestMetadata RequestMetadata
    ) : IRequest<LogoutResponse>;
}
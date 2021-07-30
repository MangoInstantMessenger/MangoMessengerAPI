using MangoAPI.DTO.Responses.Auth;
using MediatR;

namespace MangoAPI.DTO.ApiCommands.Auth
{
    public record VerifyEmailCommand : IRequest<VerifyEmailResponse>
    {
        public string Email { get; init; }
        public string UserId { get; init; }
    }
}
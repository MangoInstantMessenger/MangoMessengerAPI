using MangoAPI.BusinessLogic.Responses.Auth;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Auth
{
    public record VerifyEmailCommand : IRequest<VerifyEmailResponse>
    {
        public string Email { get; init; }
        public string UserId { get; init; }
    }
}
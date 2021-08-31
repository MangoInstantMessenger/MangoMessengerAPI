using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record VerifyEmailCommand : IRequest<VerifyEmailResponse>
    {
        public string Email { get; init; }
        public string UserId { get; init; }
    }
}

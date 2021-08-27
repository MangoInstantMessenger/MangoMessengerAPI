namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    using MediatR;

    public record VerifyEmailCommand : IRequest<VerifyEmailResponse>
    {
        public string Email { get; init; }
        public string UserId { get; init; }
    }
}

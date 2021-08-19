namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    using MediatR;

    public record LogoutAllCommand : IRequest<LogoutResponse>
    {
        public string UserId { get; init; }
    }
}

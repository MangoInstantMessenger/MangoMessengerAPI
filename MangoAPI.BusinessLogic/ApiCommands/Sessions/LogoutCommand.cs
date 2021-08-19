namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    using MediatR;

    public record LogoutCommand : IRequest<LogoutResponse>
    {
        public string RefreshToken { get; init; }
    }
}

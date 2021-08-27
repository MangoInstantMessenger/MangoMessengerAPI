namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    using MediatR;

    public record LoginCommand : IRequest<LoginResponse>
    {
        public string Email { get; init; }
        public string Password { get; init; }
    }
}

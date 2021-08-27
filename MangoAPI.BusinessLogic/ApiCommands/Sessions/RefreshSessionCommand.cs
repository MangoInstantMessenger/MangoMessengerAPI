namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    using MediatR;

    public record RefreshSessionCommand : IRequest<RefreshSessionResponse>
    {
        public string RefreshToken { get; init; }
    }
}

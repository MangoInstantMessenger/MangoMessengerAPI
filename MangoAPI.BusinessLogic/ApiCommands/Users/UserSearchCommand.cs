namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    using MediatR;

    public record UserSearchCommand : IRequest<UserSearchResponse>
    {
        public string DisplayName { get; init; }
    }
}

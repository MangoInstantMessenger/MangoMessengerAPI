using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record UserSearchCommand : IRequest<UserSearchResponse>
    {
        public string DisplayName { get; init; }
    }
}
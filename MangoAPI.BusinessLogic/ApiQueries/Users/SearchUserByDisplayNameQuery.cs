namespace MangoAPI.BusinessLogic.ApiQueries.Users
{
    using MediatR;

    public record SearchUserByDisplayNameQuery : IRequest<SearchUserByDisplayNameResponse>
    {
        public string DisplayName { get; init; }
    }
}

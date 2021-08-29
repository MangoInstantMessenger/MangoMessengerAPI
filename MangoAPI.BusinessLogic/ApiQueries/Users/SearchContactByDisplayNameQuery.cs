namespace MangoAPI.BusinessLogic.ApiQueries.Users
{
    using MediatR;

    public record SearchContactByDisplayNameQuery : IRequest<SearchContactByDisplayNameResponse>
    {
        public string UserId { get; set; }

        public string DisplayName { get; init; }
    }
}

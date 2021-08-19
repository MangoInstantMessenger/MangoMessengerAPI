namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
    using MediatR;

    public record GetContactsQuery : IRequest<GetContactsResponse>
    {
        public string UserId { get; init; }
    }
}

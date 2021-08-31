using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
    public record SearchContactByDisplayNameQuery : IRequest<SearchContactByDisplayNameResponse>
    {
        public string UserId { get; set; }

        public string DisplayName { get; init; }
    }
}
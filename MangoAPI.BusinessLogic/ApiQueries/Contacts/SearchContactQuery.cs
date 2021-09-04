using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
    public record SearchContactQuery : IRequest<SearchContactResponse>
    {
        public string UserId { get; set; }

        public string Data { get; init; }
    }
}
using MangoAPI.BusinessLogic.Responses.Contacts;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
    public record GetContactsQuery : IRequest<GetContactsResponse>
    {
        public string UserId { get; init; }
    }
}
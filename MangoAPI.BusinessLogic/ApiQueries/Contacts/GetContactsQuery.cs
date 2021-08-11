using MangoAPI.DTO.Responses.Contacts;
using MediatR;

namespace MangoAPI.DTO.ApiQueries.Contacts
{
    public record GetContactsQuery : IRequest<GetContactsResponse>
    {
        public string UserId { get; init; }
    }
}
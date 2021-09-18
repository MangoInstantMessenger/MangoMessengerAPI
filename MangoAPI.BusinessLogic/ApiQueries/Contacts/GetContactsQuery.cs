using System;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
    public record GetContactsQuery : IRequest<GetContactsResponse>
    {
        public Guid UserId { get; init; }
    }
}

using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
    public record GetContactsQuery : IRequest<GenericResponse<GetContactsResponse>>
    {
        public Guid UserId { get; init; }
    }
}

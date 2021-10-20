using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
    public record GetContactsQuery : IRequest<GenericResponse<GetContactsResponse, ErrorResponse>>
    {
        public Guid UserId { get; init; }
    }
}

using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
    public record SearchContactQuery : IRequest<GenericResponse<SearchContactResponse, ErrorResponse>>
    {
        public Guid UserId { get; init; }
        public string SearchQuery { get; init; }
    }
}
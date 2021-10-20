using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Contacts
{
    public record AddContactCommand : IRequest<GenericResponse<ResponseBase, ErrorResponse>>
    {
        public Guid ContactId { get; init; }
        public Guid UserId { get; init; }
    }
}
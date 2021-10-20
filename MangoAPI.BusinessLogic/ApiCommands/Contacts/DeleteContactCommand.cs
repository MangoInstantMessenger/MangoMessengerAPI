using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Contacts
{
    public record DeleteContactCommand : IRequest<GenericResponse<ResponseBase,ErrorResponse>>
    {
        public Guid UserId { get; init; }
        public Guid ContactId { get; init; }
    }
}
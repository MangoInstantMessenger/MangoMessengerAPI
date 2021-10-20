using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public record EditMessageCommand : IRequest<GenericResponse<ResponseBase,ErrorResponse>>
    {
        public Guid MessageId { get; init; }
        public Guid UserId { get; set; }
        public string ModifiedText { get; init; }
    }
}

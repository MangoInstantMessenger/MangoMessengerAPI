using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public record DeleteMessageCommand : IRequest<Result<DeleteMessageResponse>>
    {
        public Guid MessageId { get; init; }
        public Guid UserId { get; init; }
    }
}

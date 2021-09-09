using System;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public record DeleteMessageCommand : IRequest<DeleteMessageResponse>
    {
        public Guid MessageId { get; init; }
        public Guid UserId { get; init; }
    }
}

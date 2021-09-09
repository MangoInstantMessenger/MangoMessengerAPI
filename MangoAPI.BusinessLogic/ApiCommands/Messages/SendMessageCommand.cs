using System;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public record SendMessageCommand : IRequest<SendMessageResponse>
    {
        public string MessageText { get; init; }
        public Guid UserId { get; init; }
        public Guid ChatId { get; init; }
        public bool IsEncrypted { get; init; }
    }
}

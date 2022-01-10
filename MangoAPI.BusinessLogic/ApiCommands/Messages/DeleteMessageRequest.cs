using System;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public class DeleteMessageRequest
    {
        public Guid MessageId { get; init; }

        public Guid ChatId { get; init; }
    }
}
using MediatR;
using System;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public record SendMessageCommand : IRequest<GenericResponse<SendMessageResponse>>
    {
        public string MessageText { get; init; }
        public Guid UserId { get; set; }
        public Guid ChatId { get; init; }
        public bool IsEncrypted { get; init; }
        public string AttachmentUrl { get; init; }
        public string InReplayToAuthor { get; init; }
        public string InReplayToText { get; init; }
    }
}
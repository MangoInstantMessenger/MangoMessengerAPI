using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public record ArchiveChatCommand : IRequest<ResponseBase>
    {
        public string ChatId { get; init; }
        public string UserId { get; init; }
        public bool Archived { get; init; }
    }
}
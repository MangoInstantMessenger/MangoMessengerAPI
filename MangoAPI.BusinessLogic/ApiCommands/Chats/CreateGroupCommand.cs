namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    using MangoAPI.Domain.Enums;
    using MediatR;

    public record CreateGroupCommand : IRequest<CreateChatEntityResponse>
    {
        public ChatType GroupType { get; init; }
        public string GroupTitle { get; init; }
        public string GroupDescription { get; set; }

        public string UserId { get; init; }
    }
}

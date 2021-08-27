namespace MangoAPI.BusinessLogic.ApiQueries.Messages
{
    using MediatR;

    public record GetMessagesQuery : IRequest<GetMessagesResponse>
    {
        public string ChatId { get; init; }
        public string UserId { get; init; }
    }
}

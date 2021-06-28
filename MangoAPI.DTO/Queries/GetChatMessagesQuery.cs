using MangoAPI.DTO.Responses.Messages;
using MediatR;

namespace MangoAPI.DTO.Queries
{
    public class GetChatMessagesQuery : IRequest<GetChatMessagesResponse>
    {
    }
}
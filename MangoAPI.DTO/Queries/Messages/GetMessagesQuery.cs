using MangoAPI.DTO.Responses.Messages;
using MediatR;

namespace MangoAPI.DTO.Queries.Messages
{
    public class GetMessagesQuery : IRequest<GetMessagesResponse>
    {
    }
}
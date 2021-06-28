using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Queries;
using MangoAPI.DTO.Queries.Chats;
using MangoAPI.DTO.Queries.Messages;
using MangoAPI.DTO.Responses.Messages;
using MediatR;

namespace MangoAPI.Infrastructure.QueryHandlers.Messages
{
    public class GetChatMessagesQueryHandler : IRequestHandler<GetMessagesQuery, GetMessagesResponse>
    {
        public async Task<GetMessagesResponse> Handle(GetMessagesQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
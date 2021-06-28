using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Queries;
using MangoAPI.DTO.Responses.Messages;
using MediatR;

namespace MangoAPI.Infrastructure.QueryHandlers.Messages
{
    public class GetChatMessagesQueryHandler : IRequestHandler<GetChatMessagesQuery, GetChatMessagesResponse>
    {
        public async Task<GetChatMessagesResponse> Handle(GetChatMessagesQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
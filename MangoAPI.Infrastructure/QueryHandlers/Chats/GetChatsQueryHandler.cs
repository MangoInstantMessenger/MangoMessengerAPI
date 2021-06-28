using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Queries;
using MangoAPI.DTO.Queries.Chats;
using MangoAPI.DTO.Responses.Chats;
using MediatR;

namespace MangoAPI.Infrastructure.QueryHandlers.Chats
{
    public class GetChatsQueryHandler : IRequestHandler<GetChatsQuery, GetChatsResponse>
    {
        public async Task<GetChatsResponse> Handle(GetChatsQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
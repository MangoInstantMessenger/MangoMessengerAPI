using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Chats;
using MangoAPI.DTO.Responses.Chats;
using MediatR;

namespace MangoAPI.Infrastructure.CommandHandlers.Chats
{
    public class JoinChatCommandHandler : IRequestHandler<JoinChatCommand, JoinChatResponse>
    {
        public Task<JoinChatResponse> Handle(JoinChatCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
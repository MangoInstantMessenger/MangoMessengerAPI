using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Chats;
using MangoAPI.DTO.Responses.Chats;
using MediatR;

namespace MangoAPI.Infrastructure.CommandHandlers.Chats
{
    public class CreateChatCommandHandler : IRequestHandler<CreateChatCommand, CreateChatResponse>
    {
        public async Task<CreateChatResponse> Handle(CreateChatCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Chats;
using MangoAPI.DTO.Responses.Chats;
using MediatR;

namespace MangoAPI.Infrastructure.CommandHandlers.Chats
{
    public class CreateGroupCommandHandler : IRequestHandler<CreateGroupCommand, CreateChatEntityResponse>
    {
        public async Task<CreateChatEntityResponse> Handle(CreateGroupCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
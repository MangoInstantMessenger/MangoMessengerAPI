using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Messages;
using MangoAPI.DTO.Responses.Messages;
using MediatR;

namespace MangoAPI.Infrastructure.CommandHandlers.Messages
{
    public class DeleteChatMessageCommandHandler : IRequestHandler<DeleteChatMessageCommand, DeleteChatMessageResponse>
    {
        public async Task<DeleteChatMessageResponse> Handle(DeleteChatMessageCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
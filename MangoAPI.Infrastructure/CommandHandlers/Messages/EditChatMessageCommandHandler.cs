using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Messages;
using MangoAPI.DTO.Responses.Messages;
using MediatR;

namespace MangoAPI.Infrastructure.CommandHandlers.Messages
{
    public class EditChatMessageCommandHandler : IRequestHandler<EditChatMessageCommand, EditChatMessageResponse>
    {
        public async Task<EditChatMessageResponse> Handle(EditChatMessageCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
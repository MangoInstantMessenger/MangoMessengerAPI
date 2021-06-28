using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Messages;
using MangoAPI.DTO.Responses.Messages;
using MediatR;

namespace MangoAPI.Infrastructure.CommandHandlers.Messages
{
    public class SendChatMessageCommandHandler : IRequestHandler<SendChatMessageCommand, SendChatMessageResponse>
    {
        public async Task<SendChatMessageResponse> Handle(SendChatMessageCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
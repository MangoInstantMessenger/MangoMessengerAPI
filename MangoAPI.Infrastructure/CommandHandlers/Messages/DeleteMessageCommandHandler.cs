using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Messages;
using MangoAPI.DTO.Responses.Messages;
using MediatR;

namespace MangoAPI.Infrastructure.CommandHandlers.Messages
{
    public class DeleteMessageCommandHandler : IRequestHandler<DeleteMessageCommand, DeleteMessageResponse>
    {
        public async Task<DeleteMessageResponse> Handle(DeleteMessageCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
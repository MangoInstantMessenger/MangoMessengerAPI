using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public class ArchiveChatCommandHandler : IRequestHandler<ArchiveChatCommand, ArchiveChatResponse>
    {
        public async Task<ArchiveChatResponse> Handle(ArchiveChatCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

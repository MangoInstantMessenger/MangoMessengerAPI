using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class UpdatePublicKeyCommandHandler : IRequestHandler<UpdatePublicKeyCommand, ResponseBase>
    {
        public async Task<ResponseBase> Handle(UpdatePublicKeyCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
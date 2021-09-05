using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record UpdatePublicKeyCommand : IRequest<ResponseBase>
    {
        public string UserId { get; }
        public int PublicKey { get; }

        public UpdatePublicKeyCommand(string userId, int publicKey)
        {
            UserId = userId;
            PublicKey = publicKey;
        }
    }
}
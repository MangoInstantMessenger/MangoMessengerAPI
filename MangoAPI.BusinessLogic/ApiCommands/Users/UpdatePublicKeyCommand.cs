using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record UpdatePublicKeyCommand : IRequest<GenericResponse<ResponseBase>>
    {
        public Guid UserId { get; }
        public int PublicKey { get; }

        public UpdatePublicKeyCommand(Guid userId, int publicKey)
        {
            UserId = userId;
            PublicKey = publicKey;
        }
    }
}
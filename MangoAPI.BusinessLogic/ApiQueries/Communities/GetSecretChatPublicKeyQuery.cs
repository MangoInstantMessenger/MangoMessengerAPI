using System;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities
{
    public record GetSecretChatPublicKeyQuery : IRequest<GetSecretChatPublicKeyResponse>
    {
        public Guid ChatId { get; init; }
        public Guid UserId { get; init; }
    }
}

using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities
{
    public record GetSecretChatPublicKeyQuery : IRequest<GenericResponse<GetSecretChatPublicKeyResponse,ErrorResponse>>
    {
        public Guid ChatId { get; init; }
        public Guid UserId { get; init; }
    }
}

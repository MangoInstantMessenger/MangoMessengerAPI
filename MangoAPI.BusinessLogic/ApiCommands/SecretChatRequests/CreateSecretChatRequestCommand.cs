using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.SecretChatRequests
{
    public record CreateSecretChatRequestCommand : IRequest<Result<ResponseBase>>
    {
        public Guid UserId { get; init; }
        public Guid RequestedUserId { get; init; }
    }
}
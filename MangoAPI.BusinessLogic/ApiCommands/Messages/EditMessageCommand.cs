using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages;

public record EditMessageCommand(Guid ChatId, Guid UserId, Guid MessageId, string ModifiedText)
    : IRequest<Result<ResponseBase>>;
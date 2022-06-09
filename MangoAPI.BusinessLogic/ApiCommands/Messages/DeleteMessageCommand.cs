using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages;

public record DeleteMessageCommand(Guid UserId, Guid ChatId, Guid MessageId) : IRequest<Result<DeleteMessageResponse>>;
using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public record JoinChatCommand(Guid UserId, Guid ChatId)
    : IRequest<Result<ResponseBase>>;
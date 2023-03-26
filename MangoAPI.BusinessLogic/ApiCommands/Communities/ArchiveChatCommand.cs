using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public record ArchiveChatCommand(Guid ChatId, Guid UserId)
    : IRequest<Result<ResponseBase>>;
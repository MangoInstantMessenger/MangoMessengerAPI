using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats;

public record ArchiveChatCommand(Guid ChatId, Guid UserId)
    : IRequest<Result<ResponseBase>>;

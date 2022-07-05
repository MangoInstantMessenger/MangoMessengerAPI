using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public record CreateChannelCommand(Guid UserId, string ChannelTitle, string ChannelDescription)
    : IRequest<Result<CreateCommunityResponse>>;

using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

#pragma warning disable SA1313
public record CreateChannelCommand(Guid UserId, string ChannelTitle, string ChannelDescription)
#pragma warning restore SA1313
    : IRequest<Result<CreateCommunityResponse>>;

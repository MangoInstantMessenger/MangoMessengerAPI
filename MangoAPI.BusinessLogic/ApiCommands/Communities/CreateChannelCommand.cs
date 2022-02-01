using System;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Enums;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public record CreateChannelCommand : IRequest<Result<CreateCommunityResponse>>
{
    public string ChannelTitle { get; init; }
    public string ChannelDescription { get; init; }
    public Guid UserId { get; init; }
}
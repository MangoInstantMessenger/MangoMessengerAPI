using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public record CreateChannelCommand : IRequest<Result<CreateCommunityResponse>>
{
    public CreateChannelCommand()
    {
        
    }

    public CreateChannelCommand(string channelTitle, string channelDescription, Guid userId)
    {
        ChannelTitle = channelTitle;
        ChannelDescription = channelDescription;
        UserId = userId;
    }
    
    public string ChannelTitle { get; init; }
    public string ChannelDescription { get; init; }
    public Guid UserId { get; init; }
}
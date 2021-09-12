using System;
using MangoAPI.Domain.Enums;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public record CreateChannelCommand : IRequest<CreateCommunityResponse>
    {
        public CommunityType CommunityType { get; init; }
        public string ChannelTitle { get; init; }
        public string ChannelDescription { get; init; }
        public Guid UserId { get; init; }
    }
}
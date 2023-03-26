using FluentAssertions;
using FluentValidation;
using MangoAPI.Domain.Enums;
using MangoAPI.UnitTests.Helpers;
using Xunit;

namespace MangoAPI.UnitTests.Domain.ChatEntityTests;

public class ChatEntityCreateShouldThrowCommunityType
{
    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(3)]
    [InlineData(4)]
    public void ChatEntityCreateShouldThrowCommunityTypeOutOfRange(int communityType)
    {
        var community = (CommunityType)communityType;
        var CreateWithCommunity = () => ChatEntityHelper.CreateWithCommunityType(community);

        CreateWithCommunity.Should().ThrowExactly<ValidationException>();
    }
}
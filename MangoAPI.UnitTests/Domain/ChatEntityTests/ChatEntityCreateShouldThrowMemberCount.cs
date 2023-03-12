using FluentAssertions;
using FluentValidation;
using MangoAPI.UnitTests.Helpers;
using Xunit;

namespace MangoAPI.UnitTests.Domain.ChatEntityTests;

public class ChatEntityCreateShouldThrowMemberCount
{
    [Fact]
    public void ChatEntityCreateShouldThrowMemberCountNegative()
    {
        var createChat = () => ChatEntityHelper.CreateWithMembersCount(-10);

        createChat.Should().ThrowExactly<ValidationException>();
    }
}
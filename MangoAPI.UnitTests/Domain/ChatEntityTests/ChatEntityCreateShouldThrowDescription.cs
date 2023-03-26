using FluentAssertions;
using FluentValidation;
using MangoAPI.UnitTests.Helpers;
using System.Linq;
using Xunit;

namespace MangoAPI.UnitTests.Domain.ChatEntityTests;

public class ChatEntityCreateShouldThrowDescription
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void ChatEntityCreateShouldThrowDescriptionEmpty(string testParam)
    {
        var CreateChatEntity = () => ChatEntityHelper.CreateWithDescription(testParam);

        CreateChatEntity.Should().ThrowExactly<ValidationException>();
    }

    [Fact]
    public void ChatEntityCreateShouldThrowDescriptionOverflow()
    {
        var overflow = new string(Enumerable.Repeat('a', 102).ToArray());

        var CreateChatEntity = () => ChatEntityHelper.CreateWithDescription(overflow);

        CreateChatEntity.Should().ThrowExactly<ValidationException>();
    }
}
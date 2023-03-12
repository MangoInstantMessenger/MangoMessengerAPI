using FluentAssertions;
using FluentValidation;
using MangoAPI.Domain.Entities.ChatEntities;
using MangoAPI.UnitTests.Helpers;
using System;
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
        Func<ChatEntity> CreateChatEntity = () => ChatEntityHelper.CreateWithDescription(testParam);

        CreateChatEntity.Should().ThrowExactly<ValidationException>();
    }

    [Fact]
    public void ChatEntityCreateShouldThrowDescriptionOverflow()
    {
        var overflow = new string(Enumerable.Repeat('a', 102).ToArray());

        Func<ChatEntity> CreateChatEntity = () => ChatEntityHelper.CreateWithDescription(overflow);

        CreateChatEntity.Should().ThrowExactly<ValidationException>();
    }
}
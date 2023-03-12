using FluentAssertions;
using FluentValidation;
using MangoAPI.Domain.Entities.ChatEntities;
using MangoAPI.UnitTests.Helpers;
using System;
using System.Linq;
using Xunit;

namespace MangoAPI.UnitTests.Domain.ChatEntityTests;

public class ChatEntityCreateShouldThrowTitle
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void ChatEntityCreateShouldThrowTitleNullOrEmpty(string title)
    {
        Func<ChatEntity> CreateWithTitle = () => ChatEntityHelper.CreateWithTitle(title);

        CreateWithTitle.Should().ThrowExactly<ValidationException>();
    }

    [Fact]
    public void ChatEntityCreateShouldThrowTitleOverflow()
    {
        var title = new string(Enumerable.Repeat('a', 102).ToArray());
        Func<ChatEntity> CreateWithTitle = () => ChatEntityHelper.CreateWithTitle(title);

        CreateWithTitle.Should().ThrowExactly<ValidationException>();
    }
}
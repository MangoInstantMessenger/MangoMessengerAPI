using FluentAssertions;
using FluentValidation;
using MangoAPI.UnitTests.Helpers;
using System.Linq;
using Xunit;

namespace MangoAPI.UnitTests.Domain.ChatEntityTests;

public class ChatEntityCreateShouldThrowLastMessageText
{
    [Theory]
    [InlineData(300)]
    [InlineData(301)]
    [InlineData(302)]
    public void ChatEntityCreateShouldThrowLastMessageTextOverflow(int size)
    {
        var lastMessage = new string(Enumerable.Repeat('a', size).ToArray());
        var CreateWithLastText = () => ChatEntityHelper.CreateWithLastMessageText(lastMessage);

        if (size <= 300)
        {
            CreateWithLastText.Should().NotThrow();
            return;
        }

        CreateWithLastText.Should().ThrowExactly<ValidationException>();
    }
}
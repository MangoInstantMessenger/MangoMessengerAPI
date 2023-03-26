using FluentAssertions;
using FluentValidation;
using MangoAPI.UnitTests.Helpers;
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
        var CreateWithTitle = () => ChatEntityHelper.CreateWithTitle(title);

        CreateWithTitle.Should().ThrowExactly<ValidationException>();
    }

    [Fact]
    public void ChatEntityCreateShouldThrowTitleOverflow()
    {
        var title = new string(Enumerable.Repeat('a', 102).ToArray());
        var CreateWithTitle = () => ChatEntityHelper.CreateWithTitle(title);

        CreateWithTitle.Should().ThrowExactly<ValidationException>();
    }
}
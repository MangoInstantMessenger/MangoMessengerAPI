using FluentAssertions;
using FluentValidation;
using MangoAPI.UnitTests.Helpers;
using System.Linq;
using Xunit;

namespace MangoAPI.UnitTests.Domain.ChatEntityTests;

public class ChatEntityCreateShouldThrowImage
{
    [Fact]
    public void ChatEntityCreateShouldThrowImageOverflow()
    {
        var imageName = new string(Enumerable.Repeat('a', 102).ToArray());
        var CreateWithImage = () => ChatEntityHelper.CreateWithImage(imageName);

        CreateWithImage.Should().ThrowExactly<ValidationException>();
    }
}
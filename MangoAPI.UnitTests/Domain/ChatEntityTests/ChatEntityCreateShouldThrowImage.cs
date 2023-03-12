using FluentAssertions;
using FluentValidation;
using MangoAPI.Domain.Entities.ChatEntities;
using MangoAPI.UnitTests.Helpers;
using System;
using System.Linq;
using Xunit;

namespace MangoAPI.UnitTests.Domain.ChatEntityTests;

public class ChatEntityCreateShouldThrowImage
{
    [Fact]
    public void ChatEntityCreateShouldThrowImageOverflow()
    {
        var imageName = new string(Enumerable.Repeat('a', 102).ToArray());
        Func<ChatEntity> CreateWithImage = () => ChatEntityHelper.CreateWithImage(imageName);

        CreateWithImage.Should().ThrowExactly<ValidationException>()
            .Where(x => x.Message.Contains("Image cannot exceed 100 characters."));
    }
}
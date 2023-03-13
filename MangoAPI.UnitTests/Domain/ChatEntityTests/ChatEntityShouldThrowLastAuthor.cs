using FluentAssertions;
using FluentValidation;
using MangoAPI.Domain.Entities;
using MangoAPI.UnitTests.Helpers;
using System;
using System.Linq;
using Xunit;

namespace MangoAPI.UnitTests.Domain.ChatEntityTests;

public class ChatEntityShouldThrowLastAuthor
{
    [Theory]
    [InlineData(50)]
    [InlineData(51)]
    [InlineData(52)]
    public void ChatEntityCreateShouldThrowLastAuthorOverflow(int size)
    {
        var lastAuthor = new string(Enumerable.Repeat('a', size).ToArray());
        Func<ChatEntity> CreateWithLastAuthor = () => ChatEntityHelper.CreateWithLastMessageAuthor(lastAuthor);

        if (size <= 50)
        {
            CreateWithLastAuthor.Should().NotThrow();
            return;
        }

        CreateWithLastAuthor.Should().ThrowExactly<ValidationException>();
    }
}
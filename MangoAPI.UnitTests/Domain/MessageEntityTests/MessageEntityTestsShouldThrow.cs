using FluentAssertions;
using FluentValidation;
using MangoAPI.UnitTests.Helpers;
using System;
using System.Linq;
using Xunit;

namespace MangoAPI.UnitTests.Domain.MessageEntityTests;

public class MessageEntityTestsShouldThrow
{
    [Fact]
    public void MessageEntityTestsShouldThrowChatIdEmpty()
    {
        var act = () => MessageEntityHelper.CreateWithChatId(Guid.Empty);

        act.Should().ThrowExactly<ValidationException>();
    }

    [Fact]
    public void MessageEntityTestsShouldThrowUserIdEmpty()
    {
        var act = () => MessageEntityHelper.CreateWithUserId(Guid.Empty);

        act.Should().ThrowExactly<ValidationException>();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void MessageEntityTestsShouldThrowTextEmpty(string text)
    {
        var act = () => MessageEntityHelper.CreateWithText(text);

        act.Should().ThrowExactly<ValidationException>();
    }

    [Theory]
    [InlineData(301)]
    [InlineData(302)]
    [InlineData(303)]
    public void MessageEntityTestsShouldThrowTextOverflow(int size)
    {
        var text = new string(Enumerable.Repeat('a', size).ToArray());
        var act = () => MessageEntityHelper.CreateWithText(text);

        act.Should().ThrowExactly<ValidationException>();
    }

    [Theory]
    [InlineData(51)]
    [InlineData(52)]
    [InlineData(53)]
    public void MessageEntityTestsShouldThrowInReplyToUserOverflow(int size)
    {
        var inReplyToUser = new string(Enumerable.Repeat('a', size).ToArray());
        var act = () => MessageEntityHelper.CreateWithInReplyToUser(inReplyToUser);

        act.Should().ThrowExactly<ValidationException>();
    }

    [Theory]
    [InlineData(301)]
    [InlineData(302)]
    [InlineData(303)]
    public void MessageEntityTestsShouldThrowInReplyToTextOverflow(int size)
    {
        var inReplyToText = new string(Enumerable.Repeat('a', size).ToArray());
        var act = () => MessageEntityHelper.CreateWithInReplyToText(inReplyToText);

        act.Should().ThrowExactly<ValidationException>();
    }

    [Theory]
    [InlineData(101)]
    [InlineData(102)]
    [InlineData(103)]
    public void MessageEntityTestsShouldThrowAttachmentFileNameOverflow(int size)
    {
        var attachmentFileName = new string(Enumerable.Repeat('a', size).ToArray());
        var act = () => MessageEntityHelper.CreateWithAttachmentFileName(attachmentFileName);

        act.Should().ThrowExactly<ValidationException>();
    }

    [Theory]
    [InlineData(301)]
    [InlineData(302)]
    [InlineData(303)]
    public void MessageEntityTestsShouldThrowUpdateOverflow(int size)
    {
        var update = new string(Enumerable.Repeat('a', size).ToArray());
        var message = MessageEntityHelper.CreateSuccess();
        var act = () => message.UpdateMessageText(update);

        act.Should().ThrowExactly<ValidationException>();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void MessageEntityTestsShouldThrowUpdateEmpty(string text)
    {
        var message = MessageEntityHelper.CreateSuccess();
        var act = () => message.UpdateMessageText(text);

        act.Should().ThrowExactly<ValidationException>();
    }
}
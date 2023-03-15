using FluentAssertions;
using MangoAPI.UnitTests.Helpers;
using Xunit;

namespace MangoAPI.UnitTests.Domain.MessageEntityTests;

public class MessageEntityTestsSuccess
{
    [Fact]
    public void MessageEntityTestsShouldSuccess()
    {
        var act = MessageEntityHelper.CreateSuccess;

        act.Should().NotThrow();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void MessageEntityTestsShouldSuccessInReplyUserEmpty(string inReplyUser)
    {
        var act = () => MessageEntityHelper.CreateWithInReplyToUser(inReplyUser);

        act.Should().NotThrow();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void MessageEntityTestsShouldSuccessInReplyTextEmpty(string inReplyText)
    {
        var act = () => MessageEntityHelper.CreateWithInReplyToText(inReplyText);

        act.Should().NotThrow();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void MessageEntityTestsShouldSuccessAttachmentEmpty(string attachment)
    {
        var act = () => MessageEntityHelper.CreateWithAttachmentFileName(attachment);

        act.Should().NotThrow();
    }
}
using FluentAssertions;
using MangoAPI.UnitTests.Helpers;
using Xunit;

namespace MangoAPI.UnitTests.Domain.ChatEntityTests;

public class ChatEntityCreateTestSuccess
{
    [Fact]
    public void CreateChatEntityTestSuccess()
    {
        var CreateChatEntity = ChatEntityHelper.CreateSuccess;

        CreateChatEntity.Should().NotThrow();
    }
}
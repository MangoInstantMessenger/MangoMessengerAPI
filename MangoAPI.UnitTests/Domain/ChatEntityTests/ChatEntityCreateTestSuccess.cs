using FluentAssertions;
using MangoAPI.Domain.Entities.ChatEntities;
using MangoAPI.UnitTests.Helpers;
using System;
using Xunit;

namespace MangoAPI.UnitTests.Domain.ChatEntityTests;

public class ChatEntityCreateTestSuccess
{
    [Fact]
    public void CreateChatEntityTestSuccess()
    {
        Func<ChatEntity> CreateChatEntity = () => ChatEntityHelper.CreateSuccess();

        CreateChatEntity.Should().NotThrow();
    }
}
using FluentAssertions;
using MangoAPI.Domain.Entities;
using System;
using Xunit;

namespace MangoAPI.UnitTests.Domain.ContactEntityTests;

public class ContactEntityTestsSuccess
{
    [Fact]
    public void CreateContactEntitySuccess()
    {
        var act = () => ContactEntity.Create(Guid.NewGuid(), Guid.NewGuid());

        act.Should().NotThrow();
    }
}
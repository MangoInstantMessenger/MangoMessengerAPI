using FluentAssertions;
using FluentValidation;
using MangoAPI.Domain.Entities;
using System;
using Xunit;

namespace MangoAPI.UnitTests.Domain.ContactEntityTests;

public class ContactEntityTestsShouldThrow
{
    [Fact]
    public void CreateContactEntityShouldThrowUserIdEmpty()
    {
        var act = () => ContactEntity.Create(Guid.Empty, Guid.NewGuid());

        act.Should().ThrowExactly<ValidationException>();
    }

    [Fact]
    public void CreateContactEntityShouldThrowContactIdEmpty()
    {
        var act = () => ContactEntity.Create(Guid.NewGuid(), Guid.Empty);

        act.Should().ThrowExactly<ValidationException>();
    }
}
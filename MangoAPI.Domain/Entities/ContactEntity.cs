using FluentValidation;
using System;

namespace MangoAPI.Domain.Entities;

public class ContactEntity
{
    public Guid UserId { get; private set; }
    public Guid ContactId { get; private set; }

    public DateTime CreatedAt { get; private set; }

    public UserEntity User { get; private set; }

    private ContactEntity()
    {
    }

    private ContactEntity(Guid userId, Guid contactId)
    {
        ContactId = contactId;
        UserId = userId;
        CreatedAt = DateTime.UtcNow;

        new ContactEntityValidator().ValidateAndThrow(this);
    }

    public static ContactEntity Create(Guid userId, Guid contactId)
    {
        var contact = new ContactEntity(userId, contactId);

        return contact;
    }
}
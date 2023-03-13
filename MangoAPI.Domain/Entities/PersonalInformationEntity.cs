using System;

namespace MangoAPI.Domain.Entities;

public sealed class PersonalInformationEntity
{
    public Guid Id { get; set; }
    
    public Guid UserId { get; set; }

    public string Facebook { get; set; }

    public string Twitter { get; set; }

    public string Instagram { get; set; }

    public string LinkedIn { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public UserEntity User { get; set; }
}
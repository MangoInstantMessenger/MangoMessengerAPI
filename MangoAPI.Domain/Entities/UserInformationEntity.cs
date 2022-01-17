using System;

namespace MangoAPI.Domain.Entities;

public sealed class UserInformationEntity
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public DateTime? BirthDay { get; set; }

    public string Website { get; set; }

    public string Address { get; set; }

    public string Facebook { get; set; }

    public string Twitter { get; set; }

    public string Instagram { get; set; }

    public string LinkedIn { get; set; }

    public string ProfilePicture { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public UserEntity User { get; set; }
}
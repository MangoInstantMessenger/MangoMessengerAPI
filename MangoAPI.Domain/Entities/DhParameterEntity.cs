using System;

namespace MangoAPI.Domain.Entities;

public class DhParameterEntity
{
    public Guid Id { get; set; }
    public byte[] DhParameter { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
}
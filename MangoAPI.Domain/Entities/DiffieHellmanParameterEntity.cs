using System;

namespace MangoAPI.Domain.Entities;

public class DiffieHellmanParameterEntity
{
    public Guid Id { get; set; }

    public byte[] OpenSslDhParameter { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }
}
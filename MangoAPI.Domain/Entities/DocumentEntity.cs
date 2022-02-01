using System;

namespace MangoAPI.Domain.Entities;

public sealed class DocumentEntity
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }
        
    public string FileName { get; set; }

    public DateTime UploadedAt { get; set; }
        
    public UserEntity User { get; set; }
}
using System;

namespace MangoAPI.Domain.Entities
{
    public class DocumentEntity
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
    }
}
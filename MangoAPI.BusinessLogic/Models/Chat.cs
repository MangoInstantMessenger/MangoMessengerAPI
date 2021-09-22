using System;
using System.ComponentModel;
using MangoAPI.Domain.Enums;

namespace MangoAPI.BusinessLogic.Models
{
    public record Chat
    {
        [DefaultValue("00aed827-db8c-47de-bc81-78647030918f")]
        public Guid ChatId { get; init; }

        [DefaultValue("Test Chat")]
        public string Title { get; set; }

        [DefaultValue(4)]
        public CommunityType CommunityType { get; init; }

        [DefaultValue("https://localhost:5001/Uploads/extremecode_cpp_logo.jpg")]
        public string ChatLogoImageUrl { get; set; }

        [DefaultValue("Extreme Code C++ Public Group")]
        public string Description { get; init; }

        [DefaultValue(4)]
        public int MembersCount { get; init; }

        [DefaultValue(false)]
        public bool IsArchived { get; init; }

        [DefaultValue(true)]
        public bool IsMember { get; init; }
        
        public Message LastMessage { get; init; }
    }
}
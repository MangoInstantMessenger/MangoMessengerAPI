using System;
using System.ComponentModel;
using MangoAPI.Domain.Entities;
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
        public bool IsMember { get; set; }

        [DefaultValue("1994-07-21")]
        public DateTime? UpdatedAt { get; init; }

        [DefaultValue(1)]
        public int RoleId { get; set; }

        public Message LastMessage { get; init; }
    }

    public static class ChatEntityMapper
    {
        public static Chat ToChatDto(this ChatEntity entity)
        {
            return new Chat
            {
                ChatId = entity.Id,
                Title = entity.Title,
                CommunityType = (CommunityType)entity.CommunityType,
                Description = entity.Description,
                MembersCount = entity.MembersCount,
                IsArchived = false,
                IsMember = true,
                UpdatedAt = entity.UpdatedAt
            };
        }
    }
}
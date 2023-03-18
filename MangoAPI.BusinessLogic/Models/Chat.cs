using System;
using System.ComponentModel;
using MangoAPI.Domain.Enums;

namespace MangoAPI.BusinessLogic.Models;

public record Chat
{
    [DefaultValue("00aed827-db8c-47de-bc81-78647030918f")]
    public Guid ChatId { get; init; }

    [DefaultValue("Test Chat")] public string Title { get; set; }

    [DefaultValue(4)] public CommunityType CommunityType { get; init; }

    [DefaultValue("https://localhost:5001/Uploads/extremecode_cpp_logo.jpg")]
    public string ChatLogoImageUrl { get; set; }

    [DefaultValue("Extreme Code C++ Public Group")]
    public string Description { get; init; }

    [DefaultValue(4)] public int MembersCount { get; init; }

    [DefaultValue(false)] public bool IsArchived { get; init; }

    [DefaultValue(true)] public bool IsMember { get; set; }

    [DefaultValue(1)] public UserRole RoleId { get; init; }

    [DefaultValue("MyDisplayName")] public string LastMessageAuthor { get; init; }

    [DefaultValue("Hello world!")] public string LastMessageText { get; init; }

    [DefaultValue("10:21 PM")] public DateTime? LastMessageTime { get; init; }

    [DefaultValue("12aed827-bn8c-47de-ac81-78641210918f")]
    public Guid? LastMessageId { get; set; }

    public override string ToString()
    {
        return $"Chat Id: {ChatId} \n" +
               $"Chat Type: {CommunityType} \n" +
               $"Chat Title: {Title} \n";
    }
}

// public static class ChatEntityMapper
// {
//     public static Chat ToChatDto(this ChatEntity entity, string chatLogoImageUrl, string partnerDisplayName)
//     {
//         return new Chat
//         {
//             ChatId = entity.Id,
//             Title = partnerDisplayName,
//             CommunityType = entity.CommunityType,
//             Description = entity.Description,
//             MembersCount = entity.MembersCount,
//             IsArchived = false,
//             IsMember = true,
//             ChatLogoImageUrl = chatLogoImageUrl
//         };
//     }
// }
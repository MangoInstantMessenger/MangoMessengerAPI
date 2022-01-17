using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using System;
using System.ComponentModel;

namespace MangoAPI.BusinessLogic.Models;

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

    [DefaultValue(1)]
    public int RoleId { get; init; }

    [DefaultValue("MyDisplayName")]
    public string LastMessageAuthor { get; init; }

    [DefaultValue("Hello world!")]
    public string LastMessageText { get; init; }

    [DefaultValue("10:21 PM")]
    public string LastMessageTime { get; init; }
        
    [DefaultValue("12aed827-bn8c-47de-ac81-78641210918f")]
    public Guid? LastMessageId { get; set; }

    [DefaultValue("10/02/2021")]
    public DateTime? UpdatedAt { get; init; }

    public override string ToString()
    {
        return $"Chat Id: {ChatId} \n" +
               $"Chat Type: {CommunityType} \n" +
               $"Chat Title: {Title} \n";
    }
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
            IsMember = true
        };
    }
}
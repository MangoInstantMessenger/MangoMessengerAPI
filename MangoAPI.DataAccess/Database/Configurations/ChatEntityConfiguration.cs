using System;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.DataAccess.Database.Configurations
{
    public class ChatEntityConfiguration : IEntityTypeConfiguration<ChatEntity>
    {
        public void Configure(EntityTypeBuilder<ChatEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CommunityType).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.Title).IsRequired();

            builder.HasMany(x => x.Messages)
                .WithOne(x => x.Chat)
                .HasForeignKey(x => x.ChatId);

            builder.HasData(
                new ChatEntity
                {
                    Id = SeedDataConstants.WsbId,
                    Title = "WSB",
                    CommunityType = (int)CommunityType.PublicChannel,
                    Description = "WSB Public Group",
                    MembersCount = 5,
                    Image = "wsb_group_logo.png",
                    UpdatedAt = DateTime.UtcNow,
                    LastMessageAuthor = "Szymon Murawski",
                    LastMessageText = "Great! Good luck to all of you",
                    LastMessageTime = "9:59 PM"
                },
                new ChatEntity
                {
                    Id = SeedDataConstants.ExtremeCodeMainId,
                    Title = "Extreme Code Main",
                    CommunityType = (int)CommunityType.PublicChannel,
                    Description = "Extreme Code Main Public Group",
                    CreatedAt = new DateTime(2020, 2, 4),
                    MembersCount = 4,
                    Image = "extreme_code_main.jpg",
                    UpdatedAt = DateTime.UtcNow,
                    LastMessageAuthor = "Amelit",
                    LastMessageText = "TypeScript The Best",
                    LastMessageTime = "2:32 PM"
                },
                new ChatEntity
                {
                    Id = SeedDataConstants.ExtremeCodeFloodId,
                    Title = "Extreme Code Flood",
                    CommunityType = (int)CommunityType.PublicChannel,
                    Description = "Extreme Code Flood Public Group",
                    CreatedAt = new DateTime(2020, 4, 23),
                    MembersCount = 4,
                    Image = "extremecode_rest_logo.jpg",
                    UpdatedAt = DateTime.UtcNow,
                    LastMessageAuthor = "Amelit",
                    LastMessageText = "Слава Партии!!",
                    LastMessageTime = "6:45 PM"
                },
                new ChatEntity
                {
                    Id = SeedDataConstants.ExtremeCodeCppId,
                    Title = "Extreme Code C++",
                    CommunityType = (int)CommunityType.PublicChannel,
                    Description = "Extreme Code C++ Public Group",
                    CreatedAt = new DateTime(2020, 5, 12),
                    MembersCount = 4,
                    Image = "extremecode_cpp_logo.jpg",
                    UpdatedAt = DateTime.UtcNow,
                    LastMessageAuthor = "Amelit",
                    LastMessageText = "Hello world!",
                    LastMessageTime = "6:45 PM"
                },
                new ChatEntity
                {
                    Id = SeedDataConstants.ExtremeCodeDotnetId,
                    Title = "Extreme Code .NET",
                    CommunityType = (int)CommunityType.PublicChannel,
                    Description = "Extreme Code .NET Public Group",
                    CreatedAt = new DateTime(2020, 5, 12),
                    MembersCount = 4,
                    Image = "extremecode_dotnet.png",
                    UpdatedAt = DateTime.UtcNow,
                    LastMessageAuthor = "Amelit",
                    LastMessageText = "Hello world!",
                    LastMessageTime = "6:45 PM"
                },
                new ChatEntity
                {
                    Id = SeedDataConstants.DirectKhachaturRazumovsky,
                    Title = "Khachatur Khachatryan / razumovsky r",
                    Description = "Direct chat between Khachatur Khachatryan and razumovsky r",
                    CommunityType = (int)CommunityType.DirectChat,
                    MembersCount = 2,
                    UpdatedAt = DateTime.UtcNow,
                    LastMessageAuthor = "razumovsky r",
                    LastMessageText = "Hello world!",
                    LastMessageTime = "2.46 PM"
                },
                new ChatEntity
                {
                    Id = SeedDataConstants.DirectKolbasatorRazumovsky,
                    Title = "Мусяка Колбасяка / razumovsky r",
                    Description = "Direct chat between Мусяка Колбасяка and razumovsky r",
                    CommunityType = (int)CommunityType.DirectChat,
                    MembersCount = 2,
                    UpdatedAt = DateTime.UtcNow,
                    LastMessageAuthor = "razumovsky r",
                    LastMessageText = "Hello world!",
                    LastMessageTime = "2.47 PM"
                },
                new ChatEntity
                {
                    Id = SeedDataConstants.DirectAmelitRazumovsky,
                    Title = "Amelit / razumovsky r",
                    Description = "Direct chat between Amelit and razumovsky r",
                    CommunityType = (int)CommunityType.DirectChat,
                    MembersCount = 2,
                    UpdatedAt = DateTime.UtcNow,
                    LastMessageAuthor = "razumovsky r",
                    LastMessageText = "Hello world!",
                    LastMessageTime = "2.49 PM"
                },
                new ChatEntity
                {
                    Id = SeedDataConstants.DirectKhachaturKolbasator,
                    Title = "Khachatur Khachatryan / Мусяка Колбасяка",
                    Description = "Direct chat between Khachatur Khachatryan and Мусяка Колбасяка",
                    CommunityType = (int)CommunityType.DirectChat,
                    MembersCount = 2,
                    UpdatedAt = DateTime.UtcNow,
                    LastMessageAuthor = "Khachatur Khachatryan",
                    LastMessageText = "Hello world!",
                    LastMessageTime = "2.49 PM"
                },
                new ChatEntity
                {
                    Id = SeedDataConstants.DirectPetroSzymon,
                    Title = "Petro Kolosov / Szymon Murawski",
                    Description = "Direct chat between Petro Kolosov and Szymon Murawski",
                    CommunityType = (int)CommunityType.DirectChat,
                    MembersCount = 2,
                    UpdatedAt = DateTime.UtcNow,
                    LastMessageAuthor = "Petro Kolosov",
                    LastMessageText = "Hello world!",
                    LastMessageTime = "2.49 PM"
                });
        }
    }
}
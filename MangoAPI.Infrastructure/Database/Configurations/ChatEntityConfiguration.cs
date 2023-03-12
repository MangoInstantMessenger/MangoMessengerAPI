using System;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.Infrastructure.Database.Configurations;

public class ChatEntityConfiguration : IEntityTypeConfiguration<ChatEntity>
{
    public void Configure(EntityTypeBuilder<ChatEntity> builder)
    {
        builder.ToTable(nameof(ChatEntity), MangoDbContext.DefaultSchema);

        builder.HasKey(x => x.Id);

        builder.Property(x => x.CommunityType).IsRequired();
        builder.Property(x => x.CreatedAt).IsRequired();
        builder.Property(x => x.Title).IsRequired();

        builder.HasMany(x => x.Messages)
            .WithOne(x => x.Chat)
            .HasForeignKey(x => x.ChatId);

        // builder.HasData(
        //     new ChatEntity
        //     {
        //         Id = SeedDataConstants.WsbId,
        //         Title = "WSB",
        //         CommunityType = CommunityType.PublicChannel,
        //         CreatedAt = DateTime.UtcNow,
        //         UpdatedAt = DateTime.UtcNow,
        //         Description = "WSB Public Group",
        //         MembersCount = 5,
        //         Image = "wsb_group_logo.png",
        //         LastMessageAuthor = "Szymon Murawski",
        //         LastMessageText = "Great! Good luck to all of you",
        //         LastMessageTime = DateTime.UtcNow,
        //     },
        //     new ChatEntity
        //     {
        //         Id = SeedDataConstants.ExtremeCodeMainId,
        //         Title = "Extreme Code Main",
        //         CommunityType = CommunityType.PublicChannel,
        //         Description = "Extreme Code Main Public Group",
        //         CreatedAt = DateTime.UtcNow,
        //         UpdatedAt = DateTime.UtcNow,
        //         MembersCount = 4,
        //         Image = "extreme_code_main.jpg",
        //         LastMessageAuthor = "Amelit",
        //         LastMessageText = "TypeScript The Best",
        //         LastMessageTime = DateTime.UtcNow,
        //     },
        //     new ChatEntity
        //     {
        //         Id = SeedDataConstants.ExtremeCodeFloodId,
        //         Title = "Extreme Code Flood",
        //         CommunityType = CommunityType.PublicChannel,
        //         Description = "Extreme Code Flood Public Group",
        //         CreatedAt = DateTime.UtcNow,
        //         UpdatedAt = DateTime.UtcNow,
        //         MembersCount = 4,
        //         Image = "extremecode_rest_logo.jpg",
        //         LastMessageAuthor = "Amelit",
        //         LastMessageText = "Слава Партии!!",
        //         LastMessageTime = DateTime.UtcNow,
        //     },
        //     new ChatEntity
        //     {
        //         Id = SeedDataConstants.ExtremeCodeCppId,
        //         Title = "Extreme Code C++",
        //         CommunityType = CommunityType.PublicChannel,
        //         Description = "Extreme Code C++ Public Group",
        //         CreatedAt = DateTime.UtcNow,
        //         UpdatedAt = DateTime.UtcNow,
        //         MembersCount = 4,
        //         Image = "extremecode_cpp_logo.jpg",
        //         LastMessageAuthor = "Amelit",
        //         LastMessageText = "Hello world!",
        //         LastMessageTime = DateTime.UtcNow,
        //     },
        //     new ChatEntity
        //     {
        //         Id = SeedDataConstants.ExtremeCodeDotnetId,
        //         Title = "Extreme Code .NET",
        //         CommunityType = CommunityType.PublicChannel,
        //         Description = "Extreme Code .NET Public Group",
        //         CreatedAt = DateTime.UtcNow,
        //         UpdatedAt = DateTime.UtcNow,
        //         MembersCount = 4,
        //         Image = "extremecode_dotnet.png",
        //         LastMessageAuthor = "Amelit",
        //         LastMessageText = "Hello world!",
        //         LastMessageTime = DateTime.UtcNow,
        //     },
        //     new ChatEntity
        //     {
        //         Id = SeedDataConstants.DirectKhachaturRazumovsky,
        //         Title = "Khachatur Khachatryan / razumovsky r",
        //         Description = "Direct chat between Khachatur Khachatryan and razumovsky r",
        //         CreatedAt = DateTime.UtcNow,
        //         UpdatedAt = DateTime.UtcNow,
        //         CommunityType = CommunityType.DirectChat,
        //         MembersCount = 2,
        //         LastMessageAuthor = "razumovsky r",
        //         LastMessageText = "Hello world!",
        //         LastMessageTime = DateTime.UtcNow,
        //     },
        //     new ChatEntity
        //     {
        //         Id = SeedDataConstants.DirectKolbasatorRazumovsky,
        //         Title = "Мусяка Колбасяка / razumovsky r",
        //         Description = "Direct chat between Мусяка Колбасяка and razumovsky r",
        //         CreatedAt = DateTime.UtcNow,
        //         UpdatedAt = DateTime.UtcNow,
        //         CommunityType = CommunityType.DirectChat,
        //         MembersCount = 2,
        //         LastMessageAuthor = "razumovsky r",
        //         LastMessageText = "Hello world!",
        //         LastMessageTime = DateTime.UtcNow,
        //     },
        //     new ChatEntity
        //     {
        //         Id = SeedDataConstants.DirectAmelitRazumovsky,
        //         Title = "Amelit / razumovsky r",
        //         Description = "Direct chat between Amelit and razumovsky r",
        //         CreatedAt = DateTime.UtcNow,
        //         UpdatedAt = DateTime.UtcNow,
        //         CommunityType = CommunityType.DirectChat,
        //         MembersCount = 2,
        //         LastMessageAuthor = "razumovsky r",
        //         LastMessageText = "Hello world!",
        //         LastMessageTime = DateTime.UtcNow,
        //     },
        //     new ChatEntity
        //     {
        //         Id = SeedDataConstants.DirectKhachaturKolbasator,
        //         Title = "Khachatur Khachatryan / Мусяка Колбасяка",
        //         Description = "Direct chat between Khachatur Khachatryan and Мусяка Колбасяка",
        //         CreatedAt = DateTime.UtcNow,
        //         UpdatedAt = DateTime.UtcNow,
        //         CommunityType = CommunityType.DirectChat,
        //         MembersCount = 2,
        //         LastMessageAuthor = "Khachatur Khachatryan",
        //         LastMessageText = "Hello world!",
        //         LastMessageTime = DateTime.UtcNow,
        //     },
        //     new ChatEntity
        //     {
        //         Id = SeedDataConstants.DirectPetroSzymon,
        //         Title = "Petro Kolosov / Szymon Murawski",
        //         Description = "Direct chat between Petro Kolosov and Szymon Murawski",
        //         CreatedAt = DateTime.UtcNow,
        //         UpdatedAt = DateTime.UtcNow,
        //         CommunityType = CommunityType.DirectChat,
        //         MembersCount = 2,
        //         LastMessageAuthor = "Petro Kolosov",
        //         LastMessageText = "Hello world!",
        //         LastMessageTime = DateTime.UtcNow,
        //     });
    }
}
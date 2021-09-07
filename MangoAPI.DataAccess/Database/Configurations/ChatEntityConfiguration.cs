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
            builder.Property(x => x.ChatType).IsRequired();
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
                    ChatType = ChatType.PublicChannel,
                    Description = "WSB Public Group",
                    MembersCount = 5,
                },
                new ChatEntity
                {
                    Id = SeedDataConstants.ExtremeCodeMainId,
                    Title = "Extreme Code Main",
                    ChatType = ChatType.PublicChannel,
                    Description = "Extreme Code Main Public Group",
                    CreatedAt = new DateTime(2020, 2, 4),
                    MembersCount = 4,
                },
                new ChatEntity
                {
                    Id = SeedDataConstants.ExtremeCodeFloodId,
                    Title = "Extreme Code Flood",
                    ChatType = ChatType.PublicChannel,
                    Description = "Extreme Code Flood Public Group",
                    CreatedAt = new DateTime(2020, 4, 23),
                    MembersCount = 4,
                },
                new ChatEntity
                {
                    Id = SeedDataConstants.ExtremeCodeCppId,
                    Title = "Extreme Code C++",
                    ChatType = ChatType.PublicChannel,
                    Description = "Extreme Code C++ Public Group",
                    CreatedAt = new DateTime(2020, 5, 12),
                    MembersCount = 4,
                },
                new ChatEntity
                {
                    Id = SeedDataConstants.ExtremeCodeDotnetId,
                    Title = "Extreme Code .NET",
                    ChatType = ChatType.PublicChannel,
                    Description = "Extreme Code .NET Public Group",
                    CreatedAt = new DateTime(2020, 5, 12),
                    MembersCount = 4,
                },
                new ChatEntity
                {
                    Id = SeedDataConstants.DirectKhachaturRazumovsky,
                    Title = "Khachatur Khachatryan / razumovsky r",
                    Description = "Direct chat between Khachatur Khachatryan and razumovsky r",
                    ChatType = ChatType.DirectChat,
                    MembersCount = 2,
                },
                new ChatEntity
                {
                    Id = SeedDataConstants.DirectKolbasatorRazumovsky,
                    Title = "Мусяка Колбасяка / razumovsky r",
                    Description = "Direct chat between Мусяка Колбасяка and razumovsky r",
                    ChatType = ChatType.DirectChat,
                    MembersCount = 2,
                },
                new ChatEntity
                {
                    Id = SeedDataConstants.DirectAmelitRazumovsky,
                    Title = "Amelit / razumovsky r",
                    Description = "Direct chat between Amelit and razumovsky r",
                    ChatType = ChatType.DirectChat,
                    MembersCount = 2,
                },
                new ChatEntity
                {
                    Id = SeedDataConstants.DirectKhachaturKolbasator,
                    Title = "Khachatur Khachatryan / Мусяка Колбасяка",
                    Description = "Direct chat between Khachatur Khachatryan and Мусяка Колбасяка",
                    ChatType = ChatType.DirectChat,
                    MembersCount = 2,
                },
                new ChatEntity
                {
                    Id = SeedDataConstants.DirectPetroSzymon,
                    Title = "Petro Kolosov / Szymon Murawski",
                    Description = "Direct chat between Petro Kolosov and Szymon Murawski",
                    ChatType = ChatType.DirectChat,
                    MembersCount = 2,
                });
        }
    }
}

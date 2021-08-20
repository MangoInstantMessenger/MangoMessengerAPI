﻿namespace MangoAPI.DataAccess.Database.Configurations
{
    using System;
    using MangoAPI.Domain.Constants;
    using MangoAPI.Domain.Entities;
    using MangoAPI.Domain.Enums;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ChatEntityConfiguration : IEntityTypeConfiguration<ChatEntity>
    {
        public void Configure(EntityTypeBuilder<ChatEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ChatType).IsRequired();
            builder.Property(x => x.Created).IsRequired();
            builder.Property(x => x.Title).IsRequired();

            builder.HasMany(x => x.Messages)
                .WithOne(x => x.Chat)
                .HasForeignKey(x => x.ChatId);

            var wsbChat = new ChatEntity
            {
                Id = SeedDataConstants.WsbId,
                Title = "WSB",
                ChatType = ChatType.PublicChannel,
                MembersCount = 5,
            };

            var extremeCodeMainChat = new ChatEntity
            {
                Id = SeedDataConstants.ExtremeCodeMainId,
                Title = "Extreme Code Main",
                ChatType = ChatType.PublicChannel,
                Created = new DateTime(2020, 2, 4),
                MembersCount = 4,
            };

            var extremeCodeFloodChat = new ChatEntity
            {
                Id = SeedDataConstants.ExtremeCodeFloodId,
                Title = "Extreme Code Flood",
                ChatType = ChatType.PublicChannel,
                Created = new DateTime(2020, 4, 23),
                MembersCount = 4,
            };

            var extremeCodeCppChat = new ChatEntity
            {
                Id = SeedDataConstants.ExtremeCodeCppId,
                Title = "Extreme Code C++",
                ChatType = ChatType.PublicChannel,
                Created = new DateTime(2020, 5, 12),
                MembersCount = 4,
            };

            var extremeCodeDotnetChat = new ChatEntity
            {
                Id = SeedDataConstants.ExtremeCodeDotnetId,
                Title = "Extreme Code .NET",
                ChatType = ChatType.PublicChannel,
                Created = new DateTime(2020, 5, 12),
                MembersCount = 4,
            };

            var khachaturRazumovskyDirectChat = new ChatEntity
            {
                Id = SeedDataConstants.DirectKhachaturRazumovsky,
                Title = "Khachatur Khachatryan / razumovsky r",
                ChatType = ChatType.DirectChat,
                MembersCount = 2,
            };

            var kolbasatorRazumovskyDirectChat = new ChatEntity
            {
                Id = SeedDataConstants.DirectKolbasatorRazumovsky,
                Title = "Мусяка Колбасяка / razumovsky r",
                ChatType = ChatType.DirectChat,
                MembersCount = 2,
            };

            var amelitRazumovskyDirectChat = new ChatEntity
            {
                Id = SeedDataConstants.DirectAmelitRazumovsky,
                Title = "Amelit / razumovsky r",
                ChatType = ChatType.DirectChat,
                MembersCount = 2,
            };

            var kolbasatorKhachaturDirectChat = new ChatEntity
            {
                Id = SeedDataConstants.DirectKhachaturKolbasator,
                Title = "Khachatur Khachatryan / Мусяка Колбасяка",
                ChatType = ChatType.DirectChat,
                MembersCount = 2,
            };

            var petroSzymonDirectChat = new ChatEntity
            {
                Id = SeedDataConstants.DirectPetroSzymon,
                Title = "Petro Kolosov / Szymon Murawski",
                ChatType = ChatType.DirectChat,
                MembersCount = 2,
            };

            builder.HasData(wsbChat, extremeCodeMainChat, extremeCodeFloodChat, extremeCodeCppChat,
                extremeCodeDotnetChat, khachaturRazumovskyDirectChat, kolbasatorRazumovskyDirectChat,
                amelitRazumovskyDirectChat, kolbasatorKhachaturDirectChat, petroSzymonDirectChat);
        }
    }
}

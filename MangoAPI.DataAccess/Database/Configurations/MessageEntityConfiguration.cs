using System;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.DataAccess.Database.Configurations
{
    public class MessageEntityConfiguration : IEntityTypeConfiguration<MessageEntity>
    {
        public void Configure(EntityTypeBuilder<MessageEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(x => x.Messages)
                .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Chat)
                .WithMany(x => x.Messages)
                .HasForeignKey(x => x.ChatId);

            builder.HasData(
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.SzymonId,
                    ChatId = SeedDataConstants.WsbId,
                    Content = "Hello guys, how your diploma project goes?",
                    CreatedAt = new DateTime(2021, 8, 11, 14, 48, 21),
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.IlliaId,
                    ChatId = SeedDataConstants.WsbId,
                    Content = "Well, I'm doing UI/UX part of the project",
                    CreatedAt = new DateTime(2021, 8, 11, 14, 53, 2),
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.ArslanbekId,
                    ChatId = SeedDataConstants.WsbId,
                    Content = "Hi teacher, I perform QA of the current version",
                    CreatedAt = new DateTime(2021, 8, 11, 21, 53, 35),
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.PetroId,
                    ChatId = SeedDataConstants.WsbId,
                    Content = "Greetings. I currently workout the back-end part",
                    CreatedAt = new DateTime(2021, 8, 11, 21, 53, 57),
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.SerhiiId,
                    ChatId = SeedDataConstants.WsbId,
                    Content = "I work with backend too...",
                    CreatedAt = new DateTime(2021, 8, 11, 21, 55, 5),
                },
                new MessageEntity
                {
                    Id = "2d3a5b2b-8898-42c6-9656-9719d8174723".AsGuid(),
                    UserId = SeedDataConstants.SzymonId,
                    ChatId = SeedDataConstants.WsbId,
                    Content = "Great! Good luck to all of you",
                    CreatedAt = new DateTime(2021, 8, 11, 21, 59, 5),
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.KhachaturId,
                    ChatId = SeedDataConstants.ExtremeCodeMainId,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 13, 49, 21),
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.ExtremeCodeMainId,
                    Content = "F# The Best",
                    CreatedAt = new DateTime(2021, 8, 1, 14, 21, 56),
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.KolbasatorId,
                    ChatId = SeedDataConstants.ExtremeCodeMainId,
                    Content = "C# The Best",
                    CreatedAt = new DateTime(2021, 8, 1, 14, 22, 12),
                },
                new MessageEntity
                {
                    Id = "98bcb652-9e2d-4674-9ab0-1f63914fe77f".AsGuid(),
                    UserId = SeedDataConstants.AmelitId,
                    ChatId = SeedDataConstants.ExtremeCodeMainId,
                    Content = "TypeScript The Best",
                    CreatedAt = new DateTime(2021, 8, 1, 14, 32, 32),
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.KhachaturId,
                    ChatId = SeedDataConstants.ExtremeCodeFloodId,
                    Content = "Слава Партии!!",
                    CreatedAt = new DateTime(2021, 8, 1, 18, 42, 14),
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.ExtremeCodeFloodId,
                    Content = "Слава Партии!!",
                    CreatedAt = new DateTime(2021, 8, 1, 18, 43, 36),
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.KolbasatorId,
                    ChatId = SeedDataConstants.ExtremeCodeFloodId,
                    Content = "Слава Партии!!",
                    CreatedAt = new DateTime(2021, 8, 1, 18, 45, 13),
                },
                new MessageEntity
                {
                    Id = "cb914cf8-a511-4135-834a-8b0b51cf2879".AsGuid(),
                    UserId = SeedDataConstants.AmelitId,
                    ChatId = SeedDataConstants.ExtremeCodeFloodId,
                    Content = "Слава Партии!!",
                    CreatedAt = new DateTime(2021, 8, 1, 18, 45, 56),
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.KhachaturId,
                    ChatId = SeedDataConstants.ExtremeCodeCppId,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 18, 42, 14),
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.ExtremeCodeCppId,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 18, 43, 27),
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.KolbasatorId,
                    ChatId = SeedDataConstants.ExtremeCodeCppId,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 18, 43, 32),
                },
                new MessageEntity
                {
                    Id = "6c30406d-7444-40b9-9378-3d21f899ca5e".AsGuid(),
                    UserId = SeedDataConstants.AmelitId,
                    ChatId = SeedDataConstants.ExtremeCodeCppId,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 18, 43, 53),
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.KhachaturId,
                    ChatId = SeedDataConstants.ExtremeCodeDotnetId,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 18, 42, 14),
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.ExtremeCodeDotnetId,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 18, 43, 27),
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.KolbasatorId,
                    ChatId = SeedDataConstants.ExtremeCodeDotnetId,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 18, 43, 32),
                },
                new MessageEntity
                {
                    Id = "1bfc5ff4-b200-4ee7-bfa0-c9e77af7ce7b".AsGuid(),
                    UserId = SeedDataConstants.AmelitId,
                    ChatId = SeedDataConstants.ExtremeCodeDotnetId,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 18, 43, 53),
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.KhachaturId,
                    ChatId = SeedDataConstants.DirectKhachaturRazumovsky,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 14, 42, 14),
                },
                new MessageEntity
                {
                    Id = "7d7eb999-5264-445e-b455-726d4422d952".AsGuid(),
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.DirectKhachaturRazumovsky,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 14, 46, 29),
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.KolbasatorId,
                    ChatId = SeedDataConstants.DirectKolbasatorRazumovsky,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 14, 44, 12),
                },
                new MessageEntity
                {
                    Id = "2ed3dfbd-0770-430c-a6e0-07259a6fa82e".AsGuid(),
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.DirectKolbasatorRazumovsky,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 14, 44, 59),
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.AmelitId,
                    ChatId = SeedDataConstants.DirectAmelitRazumovsky,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 14, 21, 5),
                },
                new MessageEntity
                {
                    Id = "039aa728-7139-4597-9a6b-fa9c8de98522".AsGuid(),
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.DirectAmelitRazumovsky,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 14, 31, 23),
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.KhachaturId,
                    ChatId = SeedDataConstants.DirectKhachaturKolbasator,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 14, 21, 5),
                },
                new MessageEntity
                {
                    Id = "a07a1cab-1c10-4fef-b7fb-8bf73d373572".AsGuid(),
                    UserId = SeedDataConstants.KolbasatorId,
                    ChatId = SeedDataConstants.DirectKhachaturKolbasator,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 14, 31, 23),
                },
                new MessageEntity
                {
                    Id = "e787f41e-e379-4be4-a4ec-1c229d55bac4".AsGuid(),
                    UserId = SeedDataConstants.PetroId,
                    ChatId = SeedDataConstants.DirectPetroSzymon,
                    Content = "Hi teacher",
                    CreatedAt = new DateTime(2021, 8, 1, 14, 31, 23),
                });
        }
    }
}

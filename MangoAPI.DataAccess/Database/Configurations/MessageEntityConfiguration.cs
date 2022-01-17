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
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.IlliaId,
                    ChatId = SeedDataConstants.WsbId,
                    Content = "Well, I'm doing UI/UX part of the project",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.ArslanbekId,
                    ChatId = SeedDataConstants.WsbId,
                    Content = "Hi teacher, I perform QA of the current version",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.PetroId,
                    ChatId = SeedDataConstants.WsbId,
                    Content = "Greetings. I currently workout the back-end part",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.SerhiiId,
                    ChatId = SeedDataConstants.WsbId,
                    Content = "I work with backend too...",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.SzymonId,
                    ChatId = SeedDataConstants.WsbId,
                    Content = "Great! Good luck to all of you",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.KhachaturId,
                    ChatId = SeedDataConstants.ExtremeCodeMainId,
                    Content = "Hello World",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.ExtremeCodeMainId,
                    Content = "F# The Best",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.KolbasatorId,
                    ChatId = SeedDataConstants.ExtremeCodeMainId,
                    Content = "C# The Best",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.AmelitId,
                    ChatId = SeedDataConstants.ExtremeCodeMainId,
                    Content = "TypeScript The Best",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.KhachaturId,
                    ChatId = SeedDataConstants.ExtremeCodeFloodId,
                    Content = "Слава Партии!!",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.ExtremeCodeFloodId,
                    Content = "Слава Партии!!",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.KolbasatorId,
                    ChatId = SeedDataConstants.ExtremeCodeFloodId,
                    Content = "Слава Партии!!",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.AmelitId,
                    ChatId = SeedDataConstants.ExtremeCodeFloodId,
                    Content = "Слава Партии!!",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.KhachaturId,
                    ChatId = SeedDataConstants.ExtremeCodeCppId,
                    Content = "Hello World",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.ExtremeCodeCppId,
                    Content = "Hello World",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.KolbasatorId,
                    ChatId = SeedDataConstants.ExtremeCodeCppId,
                    Content = "Hello World",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.AmelitId,
                    ChatId = SeedDataConstants.ExtremeCodeCppId,
                    Content = "Hello World",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.KhachaturId,
                    ChatId = SeedDataConstants.ExtremeCodeDotnetId,
                    Content = "Hello World",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.ExtremeCodeDotnetId,
                    Content = "Hello World",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.KolbasatorId,
                    ChatId = SeedDataConstants.ExtremeCodeDotnetId,
                    Content = "Hello World",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.AmelitId,
                    ChatId = SeedDataConstants.ExtremeCodeDotnetId,
                    Content = "Hello World",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.KhachaturId,
                    ChatId = SeedDataConstants.DirectKhachaturRazumovsky,
                    Content = "Hello World",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.DirectKhachaturRazumovsky,
                    Content = "Hello World",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.KolbasatorId,
                    ChatId = SeedDataConstants.DirectKolbasatorRazumovsky,
                    Content = "Hello World",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.DirectKolbasatorRazumovsky,
                    Content = "Hello World",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.AmelitId,
                    ChatId = SeedDataConstants.DirectAmelitRazumovsky,
                    Content = "Hello World",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.DirectAmelitRazumovsky,
                    Content = "Hello World",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.KhachaturId,
                    ChatId = SeedDataConstants.DirectKhachaturKolbasator,
                    Content = "Hello World",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.KolbasatorId,
                    ChatId = SeedDataConstants.DirectKhachaturKolbasator,
                    Content = "Hello World",
                    CreatedAt = DateTime.UtcNow,
                },
                new MessageEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.PetroId,
                    ChatId = SeedDataConstants.DirectPetroSzymon,
                    Content = "Hi teacher",
                    CreatedAt = DateTime.UtcNow,
                });
        }
    }
}
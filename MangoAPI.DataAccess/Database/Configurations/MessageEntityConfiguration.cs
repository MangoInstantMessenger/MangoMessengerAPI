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
                    Id = "e8f26f7a-fc72-4925-b528-dbc8326b3476",
                    UserId = SeedDataConstants.SzymonId,
                    ChatId = SeedDataConstants.WsbId,
                    Content = "Hello guys, how your diploma project goes?",
                    CreatedAt = new DateTime(2021, 8, 11, 14, 48, 21),
                },
                new MessageEntity
                {
                    Id = "e1918784-455a-42c7-998e-d0b94380c21f",
                    UserId = SeedDataConstants.IlliaId,
                    ChatId = SeedDataConstants.WsbId,
                    Content = "Well, I'm doing UI/UX part of the project",
                    CreatedAt = new DateTime(2021, 8, 11, 14, 53, 2),
                },
                new MessageEntity
                {
                    Id = "5aca4139-5251-4e94-a6b1-459ebf80b3ee",
                    UserId = SeedDataConstants.ArslanbekId,
                    ChatId = SeedDataConstants.WsbId,
                    Content = "Hi teacher, I perform QA of the current version",
                    CreatedAt = new DateTime(2021, 8, 11, 21, 53, 35),
                },
                new MessageEntity
                {
                    Id = "a9e3d66a-9e19-4bd2-bf09-d02fe4540fdf",
                    UserId = SeedDataConstants.PetroId,
                    ChatId = SeedDataConstants.WsbId,
                    Content = "Greetings. I currently workout the back-end part",
                    CreatedAt = new DateTime(2021, 8, 11, 21, 53, 57),
                },
                new MessageEntity
                {
                    Id = "1dc37267-8f45-491b-9f43-d78421e79575",
                    UserId = SeedDataConstants.SerhiiId,
                    ChatId = SeedDataConstants.WsbId,
                    Content = "I work with backend too...",
                    CreatedAt = new DateTime(2021, 8, 11, 21, 55, 5),
                },
                new MessageEntity
                {
                    Id = "e8f26f7a-fc72-4925-b528-dbc8326b3477",
                    UserId = SeedDataConstants.SzymonId,
                    ChatId = SeedDataConstants.WsbId,
                    Content = "Great! Good luck to all of you",
                    CreatedAt = new DateTime(2021, 8, 11, 21, 59, 5),
                },
                new MessageEntity
                {
                    Id = "bb431cae-3df2-4c5b-9b63-cff0b74ff0d1",
                    UserId = SeedDataConstants.KhachaturId,
                    ChatId = SeedDataConstants.ExtremeCodeMainId,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 13, 49, 21),
                },
                new MessageEntity
                {
                    Id = "0c9466df-1ea2-48b8-a9f5-d5d9bd57be15",
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.ExtremeCodeMainId,
                    Content = "F# The Best",
                    CreatedAt = new DateTime(2021, 8, 1, 14, 21, 56),
                },
                new MessageEntity
                {
                    Id = "05597aa2a-4f7a-4d6d-8fdc-5d91dfce6101",
                    UserId = SeedDataConstants.KolbasatorId,
                    ChatId = SeedDataConstants.ExtremeCodeMainId,
                    Content = "C# The Best",
                    CreatedAt = new DateTime(2021, 8, 1, 14, 22, 12),
                },
                new MessageEntity
                {
                    Id = "d6fe2012-3a5e-4b36-baa8-eec4ba6a87f2",
                    UserId = SeedDataConstants.AmelitId,
                    ChatId = SeedDataConstants.ExtremeCodeMainId,
                    Content = "TypeScript The Best",
                    CreatedAt = new DateTime(2021, 8, 1, 14, 32, 32),
                },
                new MessageEntity
                {
                    Id = "8c0f730d-6b36-4071-bac9-08a5db5a54bd",
                    UserId = SeedDataConstants.KhachaturId,
                    ChatId = SeedDataConstants.ExtremeCodeFloodId,
                    Content = "Слава Партии!!",
                    CreatedAt = new DateTime(2021, 8, 1, 18, 42, 14),
                },
                new MessageEntity
                {
                    Id = "cded3336-015b-4b33-a0d2-66b5c06a97bf",
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.ExtremeCodeFloodId,
                    Content = "Слава Партии!!",
                    CreatedAt = new DateTime(2021, 8, 1, 18, 43, 36),
                },
                new MessageEntity
                {
                    Id = "83b3fe85-aa37-4692-b561-aa29c1c7b448",
                    UserId = SeedDataConstants.KolbasatorId,
                    ChatId = SeedDataConstants.ExtremeCodeFloodId,
                    Content = "Слава Партии!!",
                    CreatedAt = new DateTime(2021, 8, 1, 18, 45, 13),
                },
                new MessageEntity
                {
                    Id = "af2b6605-7b5b-4151-abb6-dc7a28138215",
                    UserId = SeedDataConstants.AmelitId,
                    ChatId = SeedDataConstants.ExtremeCodeFloodId,
                    Content = "Слава Партии!!",
                    CreatedAt = new DateTime(2021, 8, 1, 18, 45, 56),
                },
                new MessageEntity
                {
                    Id = "33ac80b1-0d3e-46cd-8175-e6e02350296e",
                    UserId = SeedDataConstants.KhachaturId,
                    ChatId = SeedDataConstants.ExtremeCodeCppId,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 18, 42, 14),
                },
                new MessageEntity
                {
                    Id = "644efffa-b05c-4f12-9b51-19fd098835a5",
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.ExtremeCodeCppId,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 18, 43, 27),
                },
                new MessageEntity
                {
                    Id = "7d525aac-81d3-4001-b1d3-373e449cbfa8",
                    UserId = SeedDataConstants.KolbasatorId,
                    ChatId = SeedDataConstants.ExtremeCodeCppId,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 18, 43, 32),
                },
                new MessageEntity
                {
                    Id = "0f9e236f-f68b-48b7-a330-eb8079277b9e",
                    UserId = SeedDataConstants.AmelitId,
                    ChatId = SeedDataConstants.ExtremeCodeCppId,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 18, 43, 53),
                },
                new MessageEntity
                {
                    Id = "dd870cc5-0acd-4dfd-9f76-e60504a6df7f",
                    UserId = SeedDataConstants.KhachaturId,
                    ChatId = SeedDataConstants.ExtremeCodeDotnetId,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 18, 42, 14),
                },
                new MessageEntity
                {
                    Id = "920a773e-828f-4cfe-9c05-5912a942eaa6",
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.ExtremeCodeDotnetId,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 18, 43, 27),
                },
                new MessageEntity
                {
                    Id = "b75ff619-8a7c-4b7d-837d-c8e46bd4579e",
                    UserId = SeedDataConstants.KolbasatorId,
                    ChatId = SeedDataConstants.ExtremeCodeDotnetId,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 18, 43, 32),
                },
                new MessageEntity
                {
                    Id = "6689401f-cb3e-484c-a3e9-a12f551b5e38",
                    UserId = SeedDataConstants.AmelitId,
                    ChatId = SeedDataConstants.ExtremeCodeDotnetId,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 18, 43, 53),
                },
                new MessageEntity
                {
                    Id = "6d49b347-c544-4d57-8f06-cf1d6994cdd0",
                    UserId = SeedDataConstants.KhachaturId,
                    ChatId = SeedDataConstants.DirectKhachaturRazumovsky,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 14, 42, 14),
                },
                new MessageEntity
                {
                    Id = "462209ae-c7a1-4021-8e55-1dd84b0cc86d",
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.DirectKhachaturRazumovsky,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 14, 46, 29),
                },
                new MessageEntity
                {
                    Id = "e5626507-b84d-4850-914c-a2ac8ae8d2d1",
                    UserId = SeedDataConstants.KolbasatorId,
                    ChatId = SeedDataConstants.DirectKolbasatorRazumovsky,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 14, 44, 12),
                },
                new MessageEntity
                {
                    Id = "c6552cd3-60a9-41b8-822a-57e07c84d805",
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.DirectKolbasatorRazumovsky,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 14, 44, 59),
                },
                new MessageEntity
                {
                    Id = "d8792fca-23df-4ae1-b83a-8a9aa5cc827a",
                    UserId = SeedDataConstants.AmelitId,
                    ChatId = SeedDataConstants.DirectAmelitRazumovsky,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 14, 21, 5),
                },
                new MessageEntity
                {
                    Id = "fbe0857c-dc77-44c7-9b3b-799a17e0869a",
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.DirectAmelitRazumovsky,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 14, 31, 23),
                },
                new MessageEntity
                {
                    Id = "c1d5d83c-447f-4320-8894-d5266090a9f5",
                    UserId = SeedDataConstants.KhachaturId,
                    ChatId = SeedDataConstants.DirectKhachaturKolbasator,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 14, 21, 5),
                },
                new MessageEntity
                {
                    Id = "c4635d82-0703-4fe6-8836-be849482ec88",
                    UserId = SeedDataConstants.KolbasatorId,
                    ChatId = SeedDataConstants.DirectKhachaturKolbasator,
                    Content = "Hello World",
                    CreatedAt = new DateTime(2021, 8, 1, 14, 31, 23),
                },
                new MessageEntity
                {
                    Id = "c4635d82-0703-4fe6-8836-be849482ec89",
                    UserId = SeedDataConstants.PetroId,
                    ChatId = SeedDataConstants.DirectPetroSzymon,
                    Content = "Hi teacher",
                    CreatedAt = new DateTime(2021, 8, 1, 14, 31, 23),
                });
        }
    }
}

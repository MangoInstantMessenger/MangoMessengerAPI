using System;
using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.Infrastructure.Database.Configurations
{
    public class MessageEntityConfiguration : IEntityTypeConfiguration<MessageEntity>
    {
        public void Configure(EntityTypeBuilder<MessageEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.Created).IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(x => x.Messages)
                .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Chat)
                .WithMany(x => x.Messages)
                .HasForeignKey(x => x.ChatId);

            builder.HasData(
                // Extreme Code Main
                new MessageEntity
                {
                    Id = "bb431cae-3df2-4c5b-9b63-cff0b74ff0d1",
                    UserId = "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                    ChatId = "0dae5a74-3528-4e85-95bb-2036bd80432c",
                    Content = "Hello World",
                    Created = new DateTime(2021, 8, 1, 13, 49, 21)
                },
                new MessageEntity
                {
                    Id = "0c9466df-1ea2-48b8-a9f5-d5d9bd57be15",
                    UserId = "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                    ChatId = "0dae5a74-3528-4e85-95bb-2036bd80432c",
                    Content = "F# The Best",
                    Created = new DateTime(2021, 8, 1, 14, 21, 56)
                },
                new MessageEntity
                {
                    Id = "05597aa2a-4f7a-4d6d-8fdc-5d91dfce6101",
                    UserId = "5b515247-f6f5-47e1-ad06-95f317a0599b",
                    ChatId = "0dae5a74-3528-4e85-95bb-2036bd80432c",
                    Content = "C# The Best",
                    Created = new DateTime(2021, 8, 1, 14, 22, 12)
                },
                new MessageEntity
                {
                    Id = "d6fe2012-3a5e-4b36-baa8-eec4ba6a87f2",
                    UserId = "d942706b-e4e2-48f9-bbdc-b022816471f0",
                    ChatId = "0dae5a74-3528-4e85-95bb-2036bd80432c",
                    Content = "TypeScript The Best",
                    Created = new DateTime(2021, 8, 1, 14, 32, 32)
                },

                // Extreme Code Flood
                new MessageEntity
                {
                    Id = "8c0f730d-6b36-4071-bac9-08a5db5a54bd",
                    UserId = "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                    ChatId = "5e656ec2-205f-471c-b095-1c80b93b7655",
                    Content = "Слава Партии!!",
                    Created = new DateTime(2021, 8, 1, 18, 42, 14)
                },
                new MessageEntity
                {
                    Id = "cded3336-015b-4b33-a0d2-66b5c06a97bf",
                    UserId = "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                    ChatId = "5e656ec2-205f-471c-b095-1c80b93b7655",
                    Content = "Слава Партии!!",
                    Created = new DateTime(2021, 8, 1, 18, 43, 36)
                },
                new MessageEntity
                {
                    Id = "83b3fe85-aa37-4692-b561-aa29c1c7b448",
                    UserId = "5b515247-f6f5-47e1-ad06-95f317a0599b",
                    ChatId = "5e656ec2-205f-471c-b095-1c80b93b7655",
                    Content = "Слава Партии!!",
                    Created = new DateTime(2021, 8, 1, 18, 45, 13)
                },
                new MessageEntity
                {
                    Id = "af2b6605-7b5b-4151-abb6-dc7a28138215",
                    UserId = "d942706b-e4e2-48f9-bbdc-b022816471f0",
                    ChatId = "5e656ec2-205f-471c-b095-1c80b93b7655",
                    Content = "Слава Партии!!",
                    Created = new DateTime(2021, 8, 1, 18, 45, 56)
                },

                // Extreme Code C++
                new MessageEntity
                {
                    Id = "33ac80b1-0d3e-46cd-8175-e6e02350296e",
                    UserId = "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                    ChatId = "cd358b94-c3b9-4022-923a-13f787f70055",
                    Content = "Hello World",
                    Created = new DateTime(2021, 8, 1, 18, 42, 14)
                },
                new MessageEntity
                {
                    Id = "644efffa-b05c-4f12-9b51-19fd098835a5",
                    UserId = "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                    ChatId = "cd358b94-c3b9-4022-923a-13f787f70055",
                    Content = "Hello World",
                    Created = new DateTime(2021, 8, 1, 18, 43, 27)
                },
                new MessageEntity
                {
                    Id = "7d525aac-81d3-4001-b1d3-373e449cbfa8",
                    UserId = "5b515247-f6f5-47e1-ad06-95f317a0599b",
                    ChatId = "cd358b94-c3b9-4022-923a-13f787f70055",
                    Content = "Hello World",
                    Created = new DateTime(2021, 8, 1, 18, 43, 32)
                },
                new MessageEntity
                {
                    Id = "0f9e236f-f68b-48b7-a330-eb8079277b9e",
                    UserId = "d942706b-e4e2-48f9-bbdc-b022816471f0",
                    ChatId = "cd358b94-c3b9-4022-923a-13f787f70055",
                    Content = "Hello World",
                    Created = new DateTime(2021, 8, 1, 18, 43, 53)
                },

                // Extreme Code .NET
                new MessageEntity
                {
                    Id = "dd870cc5-0acd-4dfd-9f76-e60504a6df7f",
                    UserId = "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                    ChatId = "6f66e318-1e94-44ae-9b33-fe001e070842",
                    Content = "Hello World",
                    Created = new DateTime(2021, 8, 1, 18, 42, 14)
                },
                new MessageEntity
                {
                    Id = "920a773e-828f-4cfe-9c05-5912a942eaa6",
                    UserId = "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                    ChatId = "6f66e318-1e94-44ae-9b33-fe001e070842",
                    Content = "Hello World",
                    Created = new DateTime(2021, 8, 1, 18, 43, 27)
                },
                new MessageEntity
                {
                    Id = "b75ff619-8a7c-4b7d-837d-c8e46bd4579e",
                    UserId = "5b515247-f6f5-47e1-ad06-95f317a0599b",
                    ChatId = "6f66e318-1e94-44ae-9b33-fe001e070842",
                    Content = "Hello World",
                    Created = new DateTime(2021, 8, 1, 18, 43, 32)
                },
                new MessageEntity
                {
                    Id = "6689401f-cb3e-484c-a3e9-a12f551b5e38",
                    UserId = "d942706b-e4e2-48f9-bbdc-b022816471f0",
                    ChatId = "6f66e318-1e94-44ae-9b33-fe001e070842",
                    Content = "Hello World",
                    Created = new DateTime(2021, 8, 1, 18, 43, 53)
                },

                // Khachatur Khachatryan / razumovsky r
                new MessageEntity
                {
                    Id = "6d49b347-c544-4d57-8f06-cf1d6994cdd0",
                    UserId = "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                    ChatId = "f5b7824f-e52b-4246-9984-06fc8e964f0c",
                    Content = "Hello World",
                    Created = new DateTime(2021, 8, 1, 14, 42, 14)
                },
                new MessageEntity
                {
                    Id = "462209ae-c7a1-4021-8e55-1dd84b0cc86d",
                    UserId = "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                    ChatId = "f5b7824f-e52b-4246-9984-06fc8e964f0c",
                    Content = "Hello World",
                    Created = new DateTime(2021, 8, 1, 14, 46, 29)
                },

                // Мусяка Колбасяка / razumovsky r
                new MessageEntity
                {
                    Id = "e5626507-b84d-4850-914c-a2ac8ae8d2d1",
                    UserId = "5b515247-f6f5-47e1-ad06-95f317a0599b",
                    ChatId = "f8729a12-5746-443f-ad31-378d846fce30",
                    Content = "Hello World",
                    Created = new DateTime(2021, 8, 1, 14, 44, 12)
                },
                new MessageEntity
                {
                    Id = "c6552cd3-60a9-41b8-822a-57e07c84d805",
                    UserId = "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                    ChatId = "f8729a12-5746-443f-ad31-378d846fce30",
                    Content = "Hello World",
                    Created = new DateTime(2021, 8, 1, 14, 44, 59)
                },

                // Amelit / razumovsky r
                new MessageEntity
                {
                    Id = "d8792fca-23df-4ae1-b83a-8a9aa5cc827a",
                    UserId = "d942706b-e4e2-48f9-bbdc-b022816471f0",
                    ChatId = "b119914a-6d95-4047-bf8a-db27deeb7dc9",
                    Content = "Hello World",
                    Created = new DateTime(2021, 8, 1, 14, 21, 5)
                },
                new MessageEntity
                {
                    Id = "fbe0857c-dc77-44c7-9b3b-799a17e0869a",
                    UserId = "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                    ChatId = "b119914a-6d95-4047-bf8a-db27deeb7dc9",
                    Content = "Hello World",
                    Created = new DateTime(2021, 8, 1, 14, 31, 23)
                },

                // Khachatur Khachatryan / Мусяка Колбасяка
                new MessageEntity
                {
                    Id = "c1d5d83c-447f-4320-8894-d5266090a9f5",
                    UserId = "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                    ChatId = "9f205dde-0ddc-401f-8fe9-6c794b661f5d",
                    Content = "Hello World",
                    Created = new DateTime(2021, 8, 1, 14, 21, 5)
                },
                new MessageEntity
                {
                    Id = "c4635d82-0703-4fe6-8836-be849482ec88",
                    UserId = "5b515247-f6f5-47e1-ad06-95f317a0599b",
                    ChatId = "9f205dde-0ddc-401f-8fe9-6c794b661f5d",
                    Content = "Hello World",
                    Created = new DateTime(2021, 8, 1, 14, 31, 23)
                }
            );
        }
    }
}
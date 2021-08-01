using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.Infrastructure.Database.Configurations
{
    public class UserChatEntityConfiguration : IEntityTypeConfiguration<UserChatEntity>
    {
        public void Configure(EntityTypeBuilder<UserChatEntity> builder)
        {
            builder.HasKey(x => new {x.ChatId, x.UserId});
            builder.Property(x => x.RoleId).IsRequired();

            builder.HasOne(x => x.Chat)
                .WithMany(x => x.ChatUsers)
                .HasForeignKey(x => x.ChatId);

            builder.HasOne(x => x.User)
                .WithMany(x => x.UserChats)
                .HasForeignKey(x => x.UserId);

            builder.HasData(
                // Extreme Code Public
                new UserChatEntity
                {
                    UserId = "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                    ChatId = "0dae5a74-3528-4e85-95bb-2036bd80432c",
                    RoleId = UserRole.User
                },
                new UserChatEntity
                {
                    UserId = "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                    ChatId = "0dae5a74-3528-4e85-95bb-2036bd80432c",
                    RoleId = UserRole.Admin
                },
                new UserChatEntity
                {
                    UserId = "5b515247-f6f5-47e1-ad06-95f317a0599b",
                    ChatId = "0dae5a74-3528-4e85-95bb-2036bd80432c",
                    RoleId = UserRole.Moderator
                },
                new UserChatEntity
                {
                    UserId = "d942706b-e4e2-48f9-bbdc-b022816471f0",
                    ChatId = "0dae5a74-3528-4e85-95bb-2036bd80432c",
                    RoleId = UserRole.Owner
                },

                // Extreme Code Flood
                new UserChatEntity
                {
                    UserId = "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                    ChatId = "5e656ec2-205f-471c-b095-1c80b93b7655",
                    RoleId = UserRole.Owner
                },
                new UserChatEntity
                {
                    UserId = "5b515247-f6f5-47e1-ad06-95f317a0599b",
                    ChatId = "5e656ec2-205f-471c-b095-1c80b93b7655",
                    RoleId = UserRole.Moderator
                },
                new UserChatEntity
                {
                    UserId = "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                    ChatId = "5e656ec2-205f-471c-b095-1c80b93b7655",
                    RoleId = UserRole.User
                },
                new UserChatEntity
                {
                    UserId = "d942706b-e4e2-48f9-bbdc-b022816471f0",
                    ChatId = "5e656ec2-205f-471c-b095-1c80b93b7655",
                    RoleId = UserRole.User
                },

                // Extreme Code C++
                new UserChatEntity
                {
                    UserId = "d942706b-e4e2-48f9-bbdc-b022816471f0",
                    ChatId = "cd358b94-c3b9-4022-923a-13f787f70055",
                    RoleId = UserRole.Owner
                },
                new UserChatEntity
                {
                    UserId = "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                    ChatId = "cd358b94-c3b9-4022-923a-13f787f70055",
                    RoleId = UserRole.Admin
                },
                new UserChatEntity
                {
                    UserId = "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                    ChatId = "cd358b94-c3b9-4022-923a-13f787f70055",
                    RoleId = UserRole.User
                },
                new UserChatEntity
                {
                    UserId = "5b515247-f6f5-47e1-ad06-95f317a0599b",
                    ChatId = "cd358b94-c3b9-4022-923a-13f787f70055",
                    RoleId = UserRole.User
                },

                // Extreme Code .NET
                new UserChatEntity
                {
                    UserId = "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                    ChatId = "6f66e318-1e94-44ae-9b33-fe001e070842",
                    RoleId = UserRole.Owner
                },
                new UserChatEntity
                {
                    UserId = "5b515247-f6f5-47e1-ad06-95f317a0599b",
                    ChatId = "6f66e318-1e94-44ae-9b33-fe001e070842",
                    RoleId = UserRole.User
                },
                new UserChatEntity
                {
                    UserId = "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                    ChatId = "6f66e318-1e94-44ae-9b33-fe001e070842",
                    RoleId = UserRole.User
                },
                new UserChatEntity
                {
                    UserId = "d942706b-e4e2-48f9-bbdc-b022816471f0",
                    ChatId = "6f66e318-1e94-44ae-9b33-fe001e070842",
                    RoleId = UserRole.User
                },

                // Khachatur Khachatryan / razumovsky r
                new UserChatEntity
                {
                    UserId = "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                    ChatId = "f5b7824f-e52b-4246-9984-06fc8e964f0c",
                    RoleId = UserRole.User
                },
                new UserChatEntity
                {
                    UserId = "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                    ChatId = "f5b7824f-e52b-4246-9984-06fc8e964f0c",
                    RoleId = UserRole.User
                },

                // Мусяка Колбасяка / razumovsky r
                new UserChatEntity
                {
                    UserId = "5b515247-f6f5-47e1-ad06-95f317a0599b",
                    ChatId = "f8729a12-5746-443f-ad31-378d846fce30",
                    RoleId = UserRole.User
                },
                new UserChatEntity
                {
                    UserId = "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                    ChatId = "f8729a12-5746-443f-ad31-378d846fce30",
                    RoleId = UserRole.User
                },

                // Amelit / razumovsky r
                new UserChatEntity
                {
                    UserId = "d942706b-e4e2-48f9-bbdc-b022816471f0",
                    ChatId = "b119914a-6d95-4047-bf8a-db27deeb7dc9",
                    RoleId = UserRole.User
                },
                new UserChatEntity
                {
                    UserId = "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                    ChatId = "b119914a-6d95-4047-bf8a-db27deeb7dc9",
                    RoleId = UserRole.User
                },

                // Khachatur Khachatryan / Мусяка Колбасяка
                new UserChatEntity
                {
                    UserId = "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                    ChatId = "9f205dde-0ddc-401f-8fe9-6c794b661f5d",
                    RoleId = UserRole.User
                },
                new UserChatEntity
                {
                    UserId = "5b515247-f6f5-47e1-ad06-95f317a0599b",
                    ChatId = "9f205dde-0ddc-401f-8fe9-6c794b661f5d",
                    RoleId = UserRole.User
                }
            );
        }
    }
}
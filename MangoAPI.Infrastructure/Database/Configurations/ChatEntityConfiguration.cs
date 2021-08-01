using System;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.Infrastructure.Database.Configurations
{
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

            builder.HasData(
                new ChatEntity
                {
                    Id = "0dae5a74-3528-4e85-95bb-2036bd80432c",
                    Title = "Extreme Code Main",
                    ChatType = ChatType.PublicChannel,
                    Created = new DateTime(2020, 2, 4),
                    MembersCount = 4
                },
                new ChatEntity
                {
                    Id = "5e656ec2-205f-471c-b095-1c80b93b7655",
                    Title = "Extreme Code Flood",
                    ChatType = ChatType.PublicChannel,
                    Created = new DateTime(2020, 4, 23),
                    MembersCount = 4
                },
                new ChatEntity
                {
                    Id = "cd358b94-c3b9-4022-923a-13f787f70055",
                    Title = "Extreme Code C++",
                    ChatType = ChatType.PublicChannel,
                    Created = new DateTime(2020, 5, 12),
                    MembersCount = 4
                },
                new ChatEntity
                {
                    Id = "6f66e318-1e94-44ae-9b33-fe001e070842",
                    Title = "Extreme Code .NET",
                    ChatType = ChatType.PublicChannel,
                    Created = new DateTime(2020, 5, 12),
                    MembersCount = 4
                },
                new ChatEntity
                {
                    Id = "f5b7824f-e52b-4246-9984-06fc8e964f0c",
                    Title = "Khachatur Khachatryan / razumovsky r",
                    ChatType = ChatType.DirectChat,
                    MembersCount = 2
                },
                new ChatEntity
                {
                    Id = "f8729a12-5746-443f-ad31-378d846fce30",
                    Title = "Мусяка Колбасяка / razumovsky r",
                    ChatType = ChatType.DirectChat,
                    MembersCount = 2
                },
                new ChatEntity
                {
                    Id = "b119914a-6d95-4047-bf8a-db27deeb7dc9",
                    Title = "Amelit / razumovsky r",
                    ChatType = ChatType.DirectChat,
                    MembersCount = 2
                },
                new ChatEntity
                {
                    Id = "9f205dde-0ddc-401f-8fe9-6c794b661f5d",
                    Title = "Khachatur Khachatryan / Мусяка Колбасяка",
                    ChatType = ChatType.DirectChat,
                    MembersCount = 2
                }
            );
        }
    }
}
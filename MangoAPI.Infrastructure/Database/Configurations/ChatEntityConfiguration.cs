﻿using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.Infrastructure.Database.Configurations;

public class ChatEntityConfiguration : IEntityTypeConfiguration<ChatEntity>
{
    public void Configure(EntityTypeBuilder<ChatEntity> builder)
    {
        builder.ToTable(nameof(ChatEntity), MangoDbContext.DefaultSchema);

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title).HasMaxLength(100).IsRequired();
        builder.Property(x => x.ImageFileName).HasMaxLength(100).IsRequired();
        builder.Property(x => x.Description).IsRequired().HasMaxLength(150);
        builder.Property(x => x.CommunityType).IsRequired();
        builder.Property(x => x.LastMessageAuthor).HasMaxLength(50);
        builder.Property(x => x.LastMessageText).HasMaxLength(300);
        builder.Property(x => x.CreatedAt).IsRequired();

        builder.HasMany(x => x.Messages)
            .WithOne(x => x.Chat)
            .HasForeignKey(x => x.ChatId);
    }
}
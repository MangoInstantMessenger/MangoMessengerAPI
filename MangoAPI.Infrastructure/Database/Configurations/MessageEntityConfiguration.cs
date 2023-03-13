using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.Infrastructure.Database.Configurations;

public class MessageEntityConfiguration : IEntityTypeConfiguration<MessageEntity>
{
    public void Configure(EntityTypeBuilder<MessageEntity> builder)
    {
        builder.ToTable(nameof(MessageEntity), MangoDbContext.DefaultSchema);

        builder.HasKey(x => x.Id);

        builder.Property(x => x.ChatId).IsRequired();
        builder.Property(x => x.UserId).IsRequired();
        builder.Property(x => x.Text).HasMaxLength(300).IsRequired();
        builder.Property(x => x.CreatedAt).IsRequired();
        builder.Property(x => x.InReplyToUser).HasMaxLength(50);
        builder.Property(x => x.InReplyToText).HasMaxLength(300);
        builder.Property(x => x.AttachmentFileName).HasMaxLength(100);

        builder.HasOne(x => x.User)
            .WithMany(x => x.Messages)
            .HasForeignKey(x => x.UserId);

        builder.HasOne(x => x.Chat)
            .WithMany(x => x.Messages)
            .HasForeignKey(x => x.ChatId);
    }
}
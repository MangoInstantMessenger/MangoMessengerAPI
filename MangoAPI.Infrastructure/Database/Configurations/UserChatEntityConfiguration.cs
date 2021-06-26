using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.Infrastructure.Database.Configurations
{
    public class UserChatEntityConfiguration: IEntityTypeConfiguration<UserChatEntity>
    {
        public void Configure(EntityTypeBuilder<UserChatEntity> builder)
        {
            builder.HasKey(x => new {x.ChatId, x.UserId});

            builder.HasOne(x => x.Chat)
                .WithMany(x => x.ChatUsers)
                .HasForeignKey(x => x.ChatId);

            builder.HasOne(x => x.User)
                .WithMany(x => x.UserChats)
                .HasForeignKey(x => x.UserId);
        }
    }
}
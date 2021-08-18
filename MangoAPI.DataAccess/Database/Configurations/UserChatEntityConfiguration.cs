using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.DataAccess.Database.Configurations
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
                // WSB
                new UserChatEntity
                {
                    UserId = SeedDataConstants.PetroId,
                    ChatId = SeedDataConstants.WsbId,
                    RoleId = UserRole.Moderator
                },
                new UserChatEntity
                {
                    UserId = SeedDataConstants.SzymonId,
                    ChatId = SeedDataConstants.WsbId,
                    RoleId = UserRole.Owner
                },
                new UserChatEntity
                {
                    UserId = SeedDataConstants.IlliaId,
                    ChatId = SeedDataConstants.WsbId,
                    RoleId = UserRole.User
                },
                new UserChatEntity
                {
                    UserId = SeedDataConstants.ArslanbekId,
                    ChatId = SeedDataConstants.WsbId,
                    RoleId = UserRole.User
                },
                new UserChatEntity
                {
                    UserId = SeedDataConstants.SerhiiId,
                    ChatId = SeedDataConstants.WsbId,
                    RoleId = UserRole.User
                },
                
                // Extreme Code Main
                new UserChatEntity
                {
                    UserId = SeedDataConstants.KhachaturId,
                    ChatId = SeedDataConstants.ExtremeCodeMainId,
                    RoleId = UserRole.User
                },
                new UserChatEntity
                {
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.ExtremeCodeMainId,
                    RoleId = UserRole.Admin
                },
                new UserChatEntity
                {
                    UserId = SeedDataConstants.KolbasatorId,
                    ChatId = SeedDataConstants.ExtremeCodeMainId,
                    RoleId = UserRole.Moderator
                },
                new UserChatEntity
                {
                    UserId = SeedDataConstants.AmelitId,
                    ChatId = SeedDataConstants.ExtremeCodeMainId,
                    RoleId = UserRole.Owner
                },

                // Extreme Code Flood
                new UserChatEntity
                {
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.ExtremeCodeFloodId,
                    RoleId = UserRole.Owner
                },
                new UserChatEntity
                {
                    UserId = SeedDataConstants.KolbasatorId,
                    ChatId = SeedDataConstants.ExtremeCodeFloodId,
                    RoleId = UserRole.Moderator
                },
                new UserChatEntity
                {
                    UserId = SeedDataConstants.KhachaturId,
                    ChatId = SeedDataConstants.ExtremeCodeFloodId,
                    RoleId = UserRole.User
                },
                new UserChatEntity
                {
                    UserId = SeedDataConstants.AmelitId,
                    ChatId = SeedDataConstants.ExtremeCodeFloodId,
                    RoleId = UserRole.User
                },

                // Extreme Code C++
                new UserChatEntity
                {
                    UserId = SeedDataConstants.AmelitId,
                    ChatId = SeedDataConstants.ExtremeCodeCppId,
                    RoleId = UserRole.Owner
                },
                new UserChatEntity
                {
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.ExtremeCodeCppId,
                    RoleId = UserRole.Admin
                },
                new UserChatEntity
                {
                    UserId = SeedDataConstants.KhachaturId,
                    ChatId = SeedDataConstants.ExtremeCodeCppId,
                    RoleId = UserRole.User
                },
                new UserChatEntity
                {
                    UserId = SeedDataConstants.KolbasatorId,
                    ChatId = SeedDataConstants.ExtremeCodeCppId,
                    RoleId = UserRole.User
                },

                // Extreme Code .NET
                new UserChatEntity
                {
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.ExtremeCodeDotnetId,
                    RoleId = UserRole.Owner
                },
                new UserChatEntity
                {
                    UserId = SeedDataConstants.KolbasatorId,
                    ChatId = SeedDataConstants.ExtremeCodeDotnetId,
                    RoleId = UserRole.User
                },
                new UserChatEntity
                {
                    UserId = SeedDataConstants.KhachaturId,
                    ChatId = SeedDataConstants.ExtremeCodeDotnetId,
                    RoleId = UserRole.User
                },
                new UserChatEntity
                {
                    UserId = SeedDataConstants.AmelitId,
                    ChatId = SeedDataConstants.ExtremeCodeDotnetId,
                    RoleId = UserRole.User
                },

                // Khachatur Khachatryan / razumovsky r
                new UserChatEntity
                {
                    UserId = SeedDataConstants.KhachaturId,
                    ChatId = SeedDataConstants.DirectKhachaturRazumovsky,
                    RoleId = UserRole.User
                },
                new UserChatEntity
                {
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.DirectKhachaturRazumovsky,
                    RoleId = UserRole.User
                },

                // Мусяка Колбасяка / razumovsky r
                new UserChatEntity
                {
                    UserId = SeedDataConstants.KolbasatorId,
                    ChatId = SeedDataConstants.DirectKolbasatorRazumovsky,
                    RoleId = UserRole.User
                },
                new UserChatEntity
                {
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.DirectKolbasatorRazumovsky,
                    RoleId = UserRole.User
                },

                // Amelit / razumovsky r
                new UserChatEntity
                {
                    UserId = SeedDataConstants.AmelitId,
                    ChatId = SeedDataConstants.DirectAmelitRazumovsky,
                    RoleId = UserRole.User
                },
                new UserChatEntity
                {
                    UserId = SeedDataConstants.RazumovskyId,
                    ChatId = SeedDataConstants.DirectAmelitRazumovsky,
                    RoleId = UserRole.User
                },

                // Khachatur Khachatryan / Мусяка Колбасяка
                new UserChatEntity
                {
                    UserId = SeedDataConstants.KhachaturId,
                    ChatId = SeedDataConstants.DirectKhachaturKolbasator,
                    RoleId = UserRole.User
                },
                new UserChatEntity
                {
                    UserId = SeedDataConstants.KolbasatorId,
                    ChatId = SeedDataConstants.DirectKhachaturKolbasator,
                    RoleId = UserRole.User
                },

                // Petro Kolosov / Szymon Murawski
                new UserChatEntity
                {
                    UserId = SeedDataConstants.PetroId,
                    ChatId = SeedDataConstants.DirectPetroSzymon,
                    RoleId = UserRole.User
                },
                new UserChatEntity
                {
                    UserId = SeedDataConstants.SzymonId,
                    ChatId = SeedDataConstants.DirectPetroSzymon,
                    RoleId = UserRole.User
                }
            );
        }
    }
}
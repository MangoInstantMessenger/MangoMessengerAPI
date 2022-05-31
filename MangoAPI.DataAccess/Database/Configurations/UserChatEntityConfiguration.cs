using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.DataAccess.Database.Configurations;

public class UserChatEntityConfiguration : IEntityTypeConfiguration<UserChatEntity>
{
    public void Configure(EntityTypeBuilder<UserChatEntity> builder)
    {
        builder.ToTable(nameof(UserChatEntity), MangoDbContext.DefaultSchema);

        builder.HasKey(x => new {x.ChatId, x.UserId});

        builder.Property(x => x.RoleId).IsRequired();

        builder.HasOne(x => x.Chat)
            .WithMany(x => x.ChatUsers)
            .HasForeignKey(x => x.ChatId);

        builder.HasOne(x => x.User)
            .WithMany(x => x.UserChats)
            .HasForeignKey(x => x.UserId);

        builder.HasData(
            new UserChatEntity
            {
                UserId = SeedDataConstants.PetroId,
                ChatId = SeedDataConstants.WsbId,
                RoleId = (int) UserRole.Moderator,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.SzymonId,
                ChatId = SeedDataConstants.WsbId,
                RoleId = (int) UserRole.Owner,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.IlliaId,
                ChatId = SeedDataConstants.WsbId,
                RoleId = (int) UserRole.User,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.ArslanbekId,
                ChatId = SeedDataConstants.WsbId,
                RoleId = (int) UserRole.User,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.SerhiiId,
                ChatId = SeedDataConstants.WsbId,
                RoleId = (int) UserRole.User,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.KhachaturId,
                ChatId = SeedDataConstants.ExtremeCodeMainId,
                RoleId = (int) UserRole.User,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = SeedDataConstants.ExtremeCodeMainId,
                RoleId = (int) UserRole.Admin,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.KolbasatorId,
                ChatId = SeedDataConstants.ExtremeCodeMainId,
                RoleId = (int) UserRole.Moderator,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.AmelitId,
                ChatId = SeedDataConstants.ExtremeCodeMainId,
                RoleId = (int) UserRole.Owner,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = SeedDataConstants.ExtremeCodeFloodId,
                RoleId = (int) UserRole.Owner,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.KolbasatorId,
                ChatId = SeedDataConstants.ExtremeCodeFloodId,
                RoleId = (int) UserRole.Moderator,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.KhachaturId,
                ChatId = SeedDataConstants.ExtremeCodeFloodId,
                RoleId = (int) UserRole.User,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.AmelitId,
                ChatId = SeedDataConstants.ExtremeCodeFloodId,
                RoleId = (int) UserRole.User,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.AmelitId,
                ChatId = SeedDataConstants.ExtremeCodeCppId,
                RoleId = (int) UserRole.Owner,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = SeedDataConstants.ExtremeCodeCppId,
                RoleId = (int) UserRole.Admin,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.KhachaturId,
                ChatId = SeedDataConstants.ExtremeCodeCppId,
                RoleId = (int) UserRole.User,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.KolbasatorId,
                ChatId = SeedDataConstants.ExtremeCodeCppId,
                RoleId = (int) UserRole.User,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = SeedDataConstants.ExtremeCodeDotnetId,
                RoleId = (int) UserRole.Owner,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.KolbasatorId,
                ChatId = SeedDataConstants.ExtremeCodeDotnetId,
                RoleId = (int) UserRole.User,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.KhachaturId,
                ChatId = SeedDataConstants.ExtremeCodeDotnetId,
                RoleId = (int) UserRole.User,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.AmelitId,
                ChatId = SeedDataConstants.ExtremeCodeDotnetId,
                RoleId = (int) UserRole.User,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.KhachaturId,
                ChatId = SeedDataConstants.DirectKhachaturRazumovsky,
                RoleId = (int) UserRole.User,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = SeedDataConstants.DirectKhachaturRazumovsky,
                RoleId = (int) UserRole.User,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.KolbasatorId,
                ChatId = SeedDataConstants.DirectKolbasatorRazumovsky,
                RoleId = (int) UserRole.User,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = SeedDataConstants.DirectKolbasatorRazumovsky,
                RoleId = (int) UserRole.User,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.AmelitId,
                ChatId = SeedDataConstants.DirectAmelitRazumovsky,
                RoleId = (int) UserRole.User,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = SeedDataConstants.DirectAmelitRazumovsky,
                RoleId = (int) UserRole.User,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.KhachaturId,
                ChatId = SeedDataConstants.DirectKhachaturKolbasator,
                RoleId = (int) UserRole.User,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.KolbasatorId,
                ChatId = SeedDataConstants.DirectKhachaturKolbasator,
                RoleId = (int) UserRole.User,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.PetroId,
                ChatId = SeedDataConstants.DirectPetroSzymon,
                RoleId = (int) UserRole.User,
            },
            new UserChatEntity
            {
                UserId = SeedDataConstants.SzymonId,
                ChatId = SeedDataConstants.DirectPetroSzymon,
                RoleId = (int) UserRole.User,
            });
    }
}
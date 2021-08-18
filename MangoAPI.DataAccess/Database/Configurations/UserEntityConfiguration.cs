using MangoAPI.Application.Services;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.DataAccess.Database.Configurations
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasMany(x => x.Sessions)
                .WithOne(x => x.UserEntity)
                .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.UserInformation)
                .WithOne(x => x.User)
                .HasForeignKey<UserInformationEntity>(x => x.UserId);

            builder.HasMany(x => x.Contacts)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            var user1 = new UserEntity
            {
                PhoneNumber = "+374 775 55 43 10",
                DisplayName = "Khachatur Khachatryan",
                Bio = "13 y. o. | C# pozer",
                Id = SeedDataConstants.KhachaturId,
                UserName = SeedDataConstants.KhachaturId,
                Email = "xachulxx@gmail.com",
                NormalizedEmail = "XACHULXX@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            var user2 = new UserEntity
            {
                PhoneNumber = "+48 743 615 532",
                DisplayName = "razumovsky r",
                Bio = "11011 y.o Dotnet Developer from $\"{cityName}\"",
                Id = SeedDataConstants.RazumovskyId,
                UserName = SeedDataConstants.RazumovskyId,
                Email = "kolosovp95@gmail.com",
                NormalizedEmail = "KOLOSOVP94@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            var user3 = new UserEntity
            {
                PhoneNumber = "+7 701 750 62 65",
                DisplayName = "Мусяка Колбасяка",
                Bio = "Колбасятор.",
                Id = SeedDataConstants.KolbasatorId,
                UserName = SeedDataConstants.KolbasatorId,
                Email = "kolbasator@gmail.com",
                NormalizedEmail = "KOLBASATOR@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            var user4 = new UserEntity
            {
                PhoneNumber = "+1 202 555 0152",
                DisplayName = "Amelit",
                Bio = "Дипломат",
                Id = SeedDataConstants.AmelitId,
                UserName = SeedDataConstants.AmelitId,
                Email = "amelit@gmail.com",
                NormalizedEmail = "AMELIT@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            var user5 = new UserEntity
            {
                PhoneNumber = "+48 743 615 532",
                DisplayName = "Petro Kolosov",
                Id = SeedDataConstants.PetroId,
                UserName = SeedDataConstants.PetroId,
                Email = "petro.kolosov@wp.pl",
                NormalizedEmail = "PETRO.KOLOSOV@WP.PL",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            var user6 = new UserEntity
            {
                PhoneNumber = "+48 743 615 532",
                DisplayName = "Szymon Murawski",
                Id = SeedDataConstants.SzymonId,
                UserName = SeedDataConstants.SzymonId,
                Email = "szymon.murawski@wp.pl",
                NormalizedEmail = "SZYMON.MURAWSKI@WP.PL",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };


            var passwordHasher = new PasswordHashService();

            passwordHasher.HashPassword(user1, "z[?6dMR#xmp=nr6q");
            passwordHasher.HashPassword(user2, "z[?6dMR#xmp=nr6q");
            passwordHasher.HashPassword(user3, "z[?6dMR#xmp=nr6q");
            passwordHasher.HashPassword(user4, "z[?6dMR#xmp=nr6q");
            passwordHasher.HashPassword(user5, "z[?6dMR#xmp=nr6q");
            passwordHasher.HashPassword(user6, "z[?6dMR#xmp=nr6q");


            builder.HasData(user1, user2, user3, user4, user5, user6);
        }
    }
}
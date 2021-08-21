namespace MangoAPI.DataAccess.Database.Configurations
{
    using System;
    using MangoAPI.Application.Services;
    using MangoAPI.Domain.Constants;
    using MangoAPI.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
                UserName = "xachulxx",
                Email = "xachulxx@gmail.com",
                NormalizedEmail = "XACHULXX@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            var user2 = new UserEntity
            {
                PhoneNumber = "+48 743 615 532",
                DisplayName = "razumovsky r",
                Bio = "11011 y.o Dotnet Developer from $\"{cityName}\"",
                Id = SeedDataConstants.RazumovskyId,
                UserName = "razumovsky_r",
                Email = "kolosovp95@gmail.com",
                NormalizedEmail = "KOLOSOVP94@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            var user3 = new UserEntity
            {
                PhoneNumber = "+7 701 750 62 65",
                DisplayName = "Мусяка Колбасяка",
                Bio = "Колбасятор.",
                Id = SeedDataConstants.KolbasatorId,
                UserName = "kolbasator",
                Email = "kolbasator@gmail.com",
                NormalizedEmail = "KOLBASATOR@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            var user4 = new UserEntity
            {
                PhoneNumber = "+1 202 555 0152",
                DisplayName = "Amelit",
                Bio = "Дипломат",
                Id = SeedDataConstants.AmelitId,
                UserName = "TheMoonlightSonata",
                Email = "amelit@gmail.com",
                NormalizedEmail = "AMELIT@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            var user5 = new UserEntity
            {
                PhoneNumber = "+48 743 615 532",
                DisplayName = "Petro Kolosov",
                Id = SeedDataConstants.PetroId,
                UserName = "petro.kolosov",
                Email = "petro.kolosov@wp.pl",
                NormalizedEmail = "PETRO.KOLOSOV@WP.PL",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            var user6 = new UserEntity
            {
                PhoneNumber = "+48 743 615 532",
                DisplayName = "Szymon Murawski",
                Id = SeedDataConstants.SzymonId,
                UserName = "szymon.murawski",
                Email = "szymon.murawski@wp.pl",
                NormalizedEmail = "SZYMON.MURAWSKI@WP.PL",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            var user7 = new UserEntity
            {
                PhoneNumber = "+48 352 643 123",
                DisplayName = "Illia Zubachov",
                Id = SeedDataConstants.IlliaId,
                UserName = "illia.zubachov",
                Email = "illia.zubachov@wp.pl",
                NormalizedEmail = "ILLIA.ZUBACHOW@WP.PL",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            var user8 = new UserEntity
            {
                PhoneNumber = "+48 278 187 781",
                DisplayName = "Arslanbek Temirbekov",
                Id = SeedDataConstants.ArslanbekId,
                UserName = "arslanbek.temirbekov",
                Email = "arslanbek.temirbekov@wp.pl",
                NormalizedEmail = "ARSLANBEK.TEMIRBEKOV@WP.PL",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            var user9 = new UserEntity
            {
                PhoneNumber = "+48 175 481 653",
                DisplayName = "Serhii Holishevskii",
                Id = SeedDataConstants.SerhiiId,
                UserName = "serhii.holishevskii",
                Email = "serhii.holishevskii@wp.pl",
                NormalizedEmail = "SERHII.HOLISHEVSKII@WP.PL",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            var passwordHasher = new PasswordHashService();

            var password = EnvironmentConstants.SeedPassword;

            if (password == null)
            {
                throw new InvalidOperationException("SEED_PASSWORD_ENV_VARIABLE_ERROR");
            }

            passwordHasher.HashPassword(user1, EnvironmentConstants.SeedPassword);
            passwordHasher.HashPassword(user2, EnvironmentConstants.SeedPassword);
            passwordHasher.HashPassword(user3, EnvironmentConstants.SeedPassword);
            passwordHasher.HashPassword(user4, EnvironmentConstants.SeedPassword);
            passwordHasher.HashPassword(user5, EnvironmentConstants.SeedPassword);
            passwordHasher.HashPassword(user6, EnvironmentConstants.SeedPassword);
            passwordHasher.HashPassword(user7, EnvironmentConstants.SeedPassword);
            passwordHasher.HashPassword(user8, EnvironmentConstants.SeedPassword);
            passwordHasher.HashPassword(user9, EnvironmentConstants.SeedPassword);

            builder.HasData(user1, user2, user3, user4, user5, user6, user7, user8, user9);
        }
    }
}

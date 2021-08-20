﻿namespace MangoAPI.DataAccess.Database.Configurations
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

            var petroKolosov = new UserEntity
            {
                PhoneNumber = "+48 743 615 532",
                DisplayName = "Petro Kolosov",
                Id = SeedDataConstants.PetroId,
                UserName = SeedDataConstants.PetroId,
                Email = "petro.kolosov@wp.pl",
                NormalizedEmail = "PETRO.KOLOSOV@WP.PL",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            var szymonMurawski = new UserEntity
            {
                PhoneNumber = "+48 743 615 532",
                DisplayName = "Szymon Murawski",
                Id = SeedDataConstants.SzymonId,
                UserName = SeedDataConstants.SzymonId,
                Email = "szymon.murawski@wp.pl",
                NormalizedEmail = "SZYMON.MURAWSKI@WP.PL",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            var illiaZubachov = new UserEntity
            {
                PhoneNumber = "+48 352 643 123",
                DisplayName = "Illia Zubachov",
                Id = SeedDataConstants.IlliaId,
                UserName = SeedDataConstants.IlliaId,
                Email = "illia.zubachov@wp.pl",
                NormalizedEmail = "ILLIA.ZUBACHOW@WP.PL",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            var arslanbekTemirbekov = new UserEntity
            {
                PhoneNumber = "+48 278 187 781",
                DisplayName = "Arslanbek Temirbekov",
                Id = SeedDataConstants.ArslanbekId,
                UserName = SeedDataConstants.ArslanbekId,
                Email = "arslanbek.temirbekov@wp.pl",
                NormalizedEmail = "ARSLANBEK.TEMIRBEKOV@WP.PL",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            var serhiiHolishevskii = new UserEntity
            {
                PhoneNumber = "+48 175 481 653",
                DisplayName = "Serhii Holishevskii",
                Id = SeedDataConstants.SerhiiId,
                UserName = SeedDataConstants.SerhiiId,
                Email = "serhii.holishevskii@wp.pl",
                NormalizedEmail = "SERHII.HOLISHEVSKII@WP.PL",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            var khachaturKhachatryan = new UserEntity
            {
                PhoneNumber = "+374 775 55 43 10",
                DisplayName = "Khachatur Khachatryan",
                Bio = "13 y. o. | C# pozer",
                Id = SeedDataConstants.KhachaturId,
                UserName = SeedDataConstants.KhachaturId,
                Email = "xachulxx@gmail.com",
                NormalizedEmail = "XACHULXX@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            var razumovskyR = new UserEntity
            {
                PhoneNumber = "+48 743 615 532",
                DisplayName = "razumovsky r",
                Bio = "11011 y.o Dotnet Developer from $\"{cityName}\"",
                Id = SeedDataConstants.RazumovskyId,
                UserName = SeedDataConstants.RazumovskyId,
                Email = "kolosovp95@gmail.com",
                NormalizedEmail = "KOLOSOVP94@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            var kolbasator = new UserEntity
            {
                PhoneNumber = "+7 701 750 62 65",
                DisplayName = "Мусяка Колбасяка",
                Bio = "Колбасятор.",
                Id = SeedDataConstants.KolbasatorId,
                UserName = SeedDataConstants.KolbasatorId,
                Email = "kolbasator@gmail.com",
                NormalizedEmail = "KOLBASATOR@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            var amelit = new UserEntity
            {
                PhoneNumber = "+1 202 555 0152",
                DisplayName = "Amelit",
                Bio = "Дипломат",
                Id = SeedDataConstants.AmelitId,
                UserName = SeedDataConstants.AmelitId,
                Email = "amelit@gmail.com",
                NormalizedEmail = "AMELIT@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            var passwordHasher = new PasswordHashService();

            var password = EnvironmentConstants.SeedPassword;

            if (password == null)
            {
                throw new InvalidOperationException("SEED_PASSWORD_ENV_VARIABLE_ERROR");
            }

            passwordHasher.HashPassword(petroKolosov, EnvironmentConstants.SeedPassword);
            passwordHasher.HashPassword(szymonMurawski, EnvironmentConstants.SeedPassword);
            passwordHasher.HashPassword(illiaZubachov, EnvironmentConstants.SeedPassword);
            passwordHasher.HashPassword(serhiiHolishevskii, EnvironmentConstants.SeedPassword);
            passwordHasher.HashPassword(arslanbekTemirbekov, EnvironmentConstants.SeedPassword);
            passwordHasher.HashPassword(khachaturKhachatryan, EnvironmentConstants.SeedPassword);
            passwordHasher.HashPassword(razumovskyR, EnvironmentConstants.SeedPassword);
            passwordHasher.HashPassword(kolbasator, EnvironmentConstants.SeedPassword);
            passwordHasher.HashPassword(amelit, EnvironmentConstants.SeedPassword);

            builder.HasData(petroKolosov, szymonMurawski, illiaZubachov, serhiiHolishevskii,
                arslanbekTemirbekov, khachaturKhachatryan, razumovskyR, kolbasator, amelit);
        }
    }
}

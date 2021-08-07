﻿using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.Infrastructure.Database.Configurations
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasMany(x => x.RefreshTokens)
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
                PhoneNumber = "+48 577 615 532",
                DisplayName = "razumovsky r",
                Bio = "11011 y.o Dotnet Developer from $\"{cityName}\"",
                Id = SeedDataConstants.RazumovskyId,
                UserName = SeedDataConstants.RazumovskyId,
                Email = "kolosovp94@gmail.com",
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

            var passwordHasher = new PasswordHashService();

            passwordHasher.HashPassword(user1, "z[?6dMR#xmp=nr6q");
            passwordHasher.HashPassword(user2, "z[?6dMR#xmp=nr6q");
            passwordHasher.HashPassword(user3, "z[?6dMR#xmp=nr6q");
            passwordHasher.HashPassword(user4, "z[?6dMR#xmp=nr6q");

            builder.HasData(user1, user2, user3, user4);
        }
    }
}
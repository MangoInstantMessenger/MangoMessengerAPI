using System;
using MangoAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity;
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
            
            var user1 = new UserEntity()
            {
                PhoneNumber = "+374 775 55 43 10",
                DisplayName = "Khachatur Khachatryan",
                Bio = "13 y. o. | C# pozer",
                Id = "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                Email = "xachulxx@gmail.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            var user2 = new UserEntity()
            {
                PhoneNumber = "+48 577 615 532",
                DisplayName = "razumovsky r",
                Bio = "11011 y.o Dotnet Developer from $\"{cityName}\"",
                Id = "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                Email = "kolosovp94@gmail.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            var user3 = new UserEntity()
            {
                PhoneNumber = "+7 701 750 62 65",
                DisplayName = "Мусяка Колбасяка",
                Bio = "Колбасятор.",
                Id = "5b515247-f6f5-47e1-ad06-95f317a0599b",
                Email = "kolbasator@gmail.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            var user4 = new UserEntity()
            {
                PhoneNumber = "+1 202 555 0152",
                DisplayName = "Amelit",
                Bio = "Дипломат",
                Id = "d942706b-e4e2-48f9-bbdc-b022816471f0",
                Email = "amelit@gmail.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            
            var passwordHasher = new PasswordHasher<UserEntity>();

            passwordHasher.HashPassword(user1, "z[?6dMR#xmp=nr6q");
            passwordHasher.HashPassword(user2, "z[?6dMR#xmp=nr6q");
            passwordHasher.HashPassword(user3, "z[?6dMR#xmp=nr6q");
            passwordHasher.HashPassword(user4, "z[?6dMR#xmp=nr6q");
            
            builder.HasData(user1, user2, user3, user4);
        }
    }
}
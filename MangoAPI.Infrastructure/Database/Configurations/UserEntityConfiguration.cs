using System;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Infrastructure.Exceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;

namespace MangoAPI.Infrastructure.Database.Configurations;

public class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.ToTable(nameof(UserEntity), MangoDbContext.DefaultSchema);

        builder.HasMany(x => x.PasswordRestoreRequests)
            .WithOne(x => x.UserEntity)
            .HasForeignKey(x => x.UserId);

        builder.HasMany(x => x.Sessions)
            .WithOne(x => x.UserEntity)
            .HasForeignKey(x => x.UserId);

        builder.HasOne(x => x.UserInformation)
            .WithOne(x => x.User)
            .HasForeignKey<UserInformationEntity>(x => x.UserId);

        builder.HasMany(x => x.Contacts)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.UserId);

        builder.HasMany(x => x.Documents)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.UserId);

        var user1 = new UserEntity
        {
            PhoneNumber = "374775554310",
            DisplayName = "Khachatur Khachatryan",
            Bio = "13 y. o. | C# pozer, Hearts Of Iron IV noob",
            Id = SeedDataConstants.KhachaturId,
            UserName = "KHACHATUR228",
            Email = "xachulxx@gmail.com",
            NormalizedEmail = "XACHULXX@GMAIL.COM",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            Image = "khachatur_picture.jpg",
        };

        var user2 = new UserEntity
        {
            PhoneNumber = "48743615532",
            DisplayName = "razumovsky r",
            Bio = "11011 y.o Dotnet Developer from $\"{cityName}\"",
            Id = SeedDataConstants.RazumovskyId,
            UserName = "razumovsky_r",
            Email = "kolosovp95@gmail.com",
            NormalizedEmail = "KOLOSOVP94@GMAIL.COM",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            Image = "razumovsky_picture.jpg",
        };

        var user3 = new UserEntity
        {
            PhoneNumber = "77017506265",
            DisplayName = "Мусяка Колбасяка",
            Bio = "Колбасятор.",
            Id = SeedDataConstants.KolbasatorId,
            UserName = "kolbasator",
            Email = "kolbasator@gmail.com",
            NormalizedEmail = "KOLBASATOR@GMAIL.COM",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            Image = "musyaka_picture.jpg",
        };

        var user4 = new UserEntity
        {
            PhoneNumber = "12025550152",
            DisplayName = "Amelit",
            Bio = "Дипломат",
            Id = SeedDataConstants.AmelitId,
            UserName = "TheMoonlightSonata",
            Email = "amelit@gmail.com",
            NormalizedEmail = "AMELIT@GMAIL.COM",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            Image = "amelit_picture.jpg",
        };

        var user5 = new UserEntity
        {
            PhoneNumber = "48743615532",
            DisplayName = "Petro Kolosov",
            Bio = "Third year student of WSB at Poznan",
            Id = SeedDataConstants.PetroId,
            UserName = "petro.kolosov",
            Email = "petro.kolosov@wp.pl",
            NormalizedEmail = "PETRO.KOLOSOV@WP.PL",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            Image = "razumovsky_picture.jpg",
        };

        var user6 = new UserEntity
        {
            PhoneNumber = "48743615532",
            DisplayName = "Szymon Murawski",
            Bio = "Teacher of Computer Science at WSB Poznan",
            Id = SeedDataConstants.SzymonId,
            UserName = "szymon.murawski",
            Email = "szymon.murawski@wp.pl",
            NormalizedEmail = "SZYMON.MURAWSKI@WP.PL",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            Image = "szymon_picture.png",
        };

        var user7 = new UserEntity
        {
            PhoneNumber = "48352643123",
            DisplayName = "Illia Zubachov",
            Bio = "Third year student of WSB at Poznan",
            Id = SeedDataConstants.IlliaId,
            UserName = "illia.zubachov",
            Email = "illia.zubachov@wp.pl",
            NormalizedEmail = "ILLIA.ZUBACHOW@WP.PL",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            Image = "illia_picture.png",
        };

        var user8 = new UserEntity
        {
            PhoneNumber = "48278187781",
            DisplayName = "Arslanbek Temirbekov",
            Bio = "Third year student of WSB at Poznan",
            Id = SeedDataConstants.ArslanbekId,
            UserName = "arslanbek.temirbekov",
            Email = "arslanbek.temirbekov@wp.pl",
            NormalizedEmail = "ARSLANBEK.TEMIRBEKOV@WP.PL",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            Image = "arslan_picture.png",
        };

        var user9 = new UserEntity
        {
            PhoneNumber = "48175481653",
            DisplayName = "Serhii Holishevskii",
            Bio = "Third year student of WSB at Poznan",
            Id = SeedDataConstants.SerhiiId,
            UserName = "serhii.holishevskii",
            Email = "serhii.holishevskii@wp.pl",
            NormalizedEmail = "SERHII.HOLISHEVSKII@WP.PL",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            Image = "serhii_picture.png",
        };

        var passwordHasher = new PasswordHashService();

        const string seedPassword = "Dn2-~bRPw+*vR9(cw^84";

        passwordHasher.HashPassword(user1, seedPassword);
        passwordHasher.HashPassword(user2, seedPassword);
        passwordHasher.HashPassword(user3, seedPassword);
        passwordHasher.HashPassword(user4, seedPassword);
        passwordHasher.HashPassword(user5, seedPassword);
        passwordHasher.HashPassword(user6, seedPassword);
        passwordHasher.HashPassword(user7, seedPassword);
        passwordHasher.HashPassword(user8, seedPassword);
        passwordHasher.HashPassword(user9, seedPassword);

        builder.HasData(user1, user2, user3, user4, user5, user6, user7, user8, user9);
    }
}

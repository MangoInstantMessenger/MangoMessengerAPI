using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using MangoAPI.Domain.Constants;

namespace MangoAPI.Tests
{
    public class DbContextFixture : IDisposable
    {
        public DbContextFixture()
        {
            var options = new DbContextOptionsBuilder<MangoPostgresDbContext>()
                .UseInMemoryDatabase("MangoApiDatabase")
                .Options;

            PostgresDbContext = new MangoPostgresDbContext(options);
            PostgresDbContext.Database.EnsureDeleted();

            SeedUsers();
            SeedUserInformation();
            SeedUserSessions();
            SeedChats();
            SeedUserChats();
            SeedMessages();
            SeedContacts();
        }

        public MangoPostgresDbContext PostgresDbContext { get; }

        public void Dispose()
        {
            PostgresDbContext.Database.EnsureDeleted();
            PostgresDbContext.Dispose();
            GC.SuppressFinalize(this);
        }

        private void SeedUsers()
        {
            PostgresDbContext.Users.AddRange(SeedData.Users);
            PostgresDbContext.SaveChanges();
        }

        private void SeedUserInformation()
        {
            PostgresDbContext.UserInformation.AddRange(SeedData.UserInfo);
            PostgresDbContext.SaveChanges();
        }

        private void SeedUserSessions()
        {
            PostgresDbContext.Sessions.AddRange(SeedData.UserSessions);
            PostgresDbContext.SaveChanges();
        }

        private void SeedChats()
        {
            PostgresDbContext.Chats.AddRange(SeedData.Chats);
            PostgresDbContext.SaveChanges();
        }

        private void SeedUserChats()
        {
            PostgresDbContext.UserChats.AddRange(SeedData.UserChats);
            PostgresDbContext.SaveChanges();
        }

        private void SeedMessages()
        {
            PostgresDbContext.Messages.AddRange(SeedData.Messages);
            PostgresDbContext.SaveChanges();
        }

        private void SeedContacts()
        {
            PostgresDbContext.UserContacts.AddRange(SeedData.Contacts);
            PostgresDbContext.SaveChanges();
        }
    }

    internal static class SeedData
    {
        public static List<UserEntity> Users
        {
            get
            {
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
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    PhoneCode = 555555
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
                };

                return new List<UserEntity>
                {
                    user1, user2, user3, user4, user5, user6, user7, user8, user9
                };
            }
        }

        public static List<UserInformationEntity> UserInfo => new()
        {
            new UserInformationEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.PetroId,
                BirthDay = new DateTime(1994, 6, 12),
                Website = "petro.kolosov.com",
                Instagram = "petro.kolosov",
                LinkedIn = "petro.kolosov",
                Facebook = "petro.kolosov",
                Twitter = "petro.kolosov",
                Address = "Poznan, Poland",
            },
            new UserInformationEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.IlliaId,
                BirthDay = new DateTime(1994, 6, 12),
                Website = "illia.zubachov.com",
                Instagram = "illia.zubachov",
                LinkedIn = "illia.zubachov",
                Facebook = "illia.zubachov",
                Twitter = "illia.zubachov",
                Address = "Poznan, Poland",
            },
            new UserInformationEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.SerhiiId,
                BirthDay = new DateTime(1994, 6, 12),
                Website = "serhii.holishevskii.com",
                Instagram = "serhii.holishevskii",
                LinkedIn = "serhii.holishevskii",
                Facebook = "serhii.holishevskii",
                Twitter = "serhii.holishevskii",
                Address = "Poznan, Poland",
            },
            new UserInformationEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.ArslanbekId,
                BirthDay = new DateTime(1994, 6, 12),
                Website = "arslan.temirbekov.com",
                Instagram = "arslan.temirbekov",
                LinkedIn = "arslan.temirbekov",
                Facebook = "arslan.temirbekov",
                Twitter = "arslan.temirbekov",
                Address = "Poznan, Poland",
            },
            new UserInformationEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.SzymonId,
                BirthDay = new DateTime(1983, 5, 25),
                Website = "szymon.murawski.com",
                Instagram = "szymon.murawski",
                LinkedIn = "szymon.murawski",
                Facebook = "szymon.murawski",
                Twitter = "szymon.murawski",
                Address = "Poznan, Poland",
            },
            new UserInformationEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.KhachaturId,
                BirthDay = new DateTime(2008, 3, 7),
                Website = "khachapur.com",
                Instagram = "khachapur.mudrenych",
                LinkedIn = "khachapur.mudrenych",
                Address = "Moscow, Russia",
            },
            new UserInformationEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.RazumovskyId,
                BirthDay = new DateTime(1994, 7, 21),
                Address = "Odessa, Ukraine",
                Website = "razumovsky.com",
                Twitter = "razumovsky_r",
                Facebook = "razumovsky_r",
                Instagram = "razumovsky_r",
                LinkedIn = "razumovsky_r",
            },
            new UserInformationEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.KolbasatorId,
                Website = "kolbasator.com",
                Facebook = "kolbasator",
                ProfilePicture = "profile.png",
                Address = "Saint-Petersburg, Russia",
            },
            new UserInformationEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.AmelitId,
                Facebook = "TheMoonlightSonata",
                Instagram = "TheMoonlightSonata",
                Twitter = "TheMoonlightSonata",
                Address = "Moscow, Russia",
            }
        };

        public static List<SessionEntity> UserSessions => new()
        {
            new SessionEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.PetroId,
                RefreshToken = "69dbef09-de5a-4da7-9d67-abeba1510118".AsGuid(),
                CreatedAt = DateTime.UtcNow,
                ExpiresAt = DateTime.UtcNow.AddDays(3),
            },
            new SessionEntity
            {
                Id = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                RefreshToken = "219d9df3-9bc0-4679-baaa-c18b1c7524e8".AsGuid(),
                CreatedAt = DateTime.UtcNow,
                ExpiresAt = DateTime.UtcNow.AddDays(3),
            },
        };

        public static List<ChatEntity> Chats => new()
        {
            new ChatEntity
            {
                CommunityType = (int) CommunityType.PublicChannel,
                Title = "Extreme Code Main",
                Id = SeedDataConstants.ExtremeCodeMainId,
            },
            new ChatEntity
            {
                CommunityType = (int) CommunityType.PrivateChannel,
                Title = "Extreme Code C++",
                Id = SeedDataConstants.ExtremeCodeCppId,
            },
            new ChatEntity
            {
                CommunityType = (int) CommunityType.ReadOnlyChannel,
                Title = "Extreme Code",
                Id = SeedDataConstants.ExtremeCodeDotnetId,
            },
            new ChatEntity
            {
                CommunityType = (int) CommunityType.PrivateChannel,
                Title = "Extreme Code Flood",
                Id = SeedDataConstants.ExtremeCodeFloodId,
            },
            new ChatEntity
            {
                CommunityType = (int) CommunityType.DirectChat,
                Title = "Petro / Szymon",
                Id = SeedDataConstants.DirectPetroSzymon
            },
            new ChatEntity
            {
                Id = SeedDataConstants.WsbId,
                Title = "WSB",
                CommunityType = (int) CommunityType.PublicChannel,
                Description = "WSB Public Group",
                MembersCount = 5,
            }
        };

        public static List<UserChatEntity> UserChats => new()
        {
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
            }
        };

        public static List<MessageEntity> Messages => new()
        {
            new MessageEntity
            {
                Id = "664b168f-565c-4a94-b2f5-7b199bd1c364".AsGuid(),
                UserId = SeedDataConstants.SzymonId,
                ChatId = SeedDataConstants.WsbId,
                Content = "Hello guys, how your diploma project goes?",
                CreatedAt = new DateTime(2021, 8, 11, 14, 48, 21),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.IlliaId,
                ChatId = SeedDataConstants.WsbId,
                Content = "Well, I'm doing UI/UX part of the project",
                CreatedAt = new DateTime(2021, 8, 11, 14, 53, 2),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.ArslanbekId,
                ChatId = SeedDataConstants.WsbId,
                Content = "Hi teacher, I perform QA of the current version",
                CreatedAt = new DateTime(2021, 8, 11, 21, 53, 35),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.PetroId,
                ChatId = SeedDataConstants.WsbId,
                Content = "Greetings. I currently workout the back-end part",
                CreatedAt = new DateTime(2021, 8, 11, 21, 53, 57),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.SerhiiId,
                ChatId = SeedDataConstants.WsbId,
                Content = "I work with backend too...",
                CreatedAt = new DateTime(2021, 8, 11, 21, 55, 5),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.SzymonId,
                ChatId = SeedDataConstants.WsbId,
                Content = "Great! Good luck to all of you",
                CreatedAt = new DateTime(2021, 8, 11, 21, 59, 5),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.KhachaturId,
                ChatId = SeedDataConstants.ExtremeCodeMainId,
                Content = "Hello World",
                CreatedAt = new DateTime(2021, 8, 1, 13, 49, 21),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = SeedDataConstants.ExtremeCodeMainId,
                Content = "F# The Best",
                CreatedAt = new DateTime(2021, 8, 1, 14, 21, 56),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.KolbasatorId,
                ChatId = SeedDataConstants.ExtremeCodeMainId,
                Content = "C# The Best",
                CreatedAt = new DateTime(2021, 8, 1, 14, 22, 12),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.AmelitId,
                ChatId = SeedDataConstants.ExtremeCodeMainId,
                Content = "TypeScript The Best",
                CreatedAt = new DateTime(2021, 8, 1, 14, 32, 32),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.KhachaturId,
                ChatId = SeedDataConstants.ExtremeCodeFloodId,
                Content = "Слава Партии!!",
                CreatedAt = new DateTime(2021, 8, 1, 18, 42, 14),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = SeedDataConstants.ExtremeCodeFloodId,
                Content = "Слава Партии!!",
                CreatedAt = new DateTime(2021, 8, 1, 18, 43, 36),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.KolbasatorId,
                ChatId = SeedDataConstants.ExtremeCodeFloodId,
                Content = "Слава Партии!!",
                CreatedAt = new DateTime(2021, 8, 1, 18, 45, 13),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.AmelitId,
                ChatId = SeedDataConstants.ExtremeCodeFloodId,
                Content = "Слава Партии!!",
                CreatedAt = new DateTime(2021, 8, 1, 18, 45, 56),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.KhachaturId,
                ChatId = SeedDataConstants.ExtremeCodeCppId,
                Content = "Hello World",
                CreatedAt = new DateTime(2021, 8, 1, 18, 42, 14),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = SeedDataConstants.ExtremeCodeCppId,
                Content = "Hello World",
                CreatedAt = new DateTime(2021, 8, 1, 18, 43, 27),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.KolbasatorId,
                ChatId = SeedDataConstants.ExtremeCodeCppId,
                Content = "Hello World",
                CreatedAt = new DateTime(2021, 8, 1, 18, 43, 32),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.AmelitId,
                ChatId = SeedDataConstants.ExtremeCodeCppId,
                Content = "Hello World",
                CreatedAt = new DateTime(2021, 8, 1, 18, 43, 53),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.KhachaturId,
                ChatId = SeedDataConstants.ExtremeCodeDotnetId,
                Content = "Hello World",
                CreatedAt = new DateTime(2021, 8, 1, 18, 42, 14),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = SeedDataConstants.ExtremeCodeDotnetId,
                Content = "Hello World",
                CreatedAt = new DateTime(2021, 8, 1, 18, 43, 27),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.KolbasatorId,
                ChatId = SeedDataConstants.ExtremeCodeDotnetId,
                Content = "Hello World",
                CreatedAt = new DateTime(2021, 8, 1, 18, 43, 32),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.AmelitId,
                ChatId = SeedDataConstants.ExtremeCodeDotnetId,
                Content = "Hello World",
                CreatedAt = new DateTime(2021, 8, 1, 18, 43, 53),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.KhachaturId,
                ChatId = SeedDataConstants.DirectKhachaturRazumovsky,
                Content = "Hello World",
                CreatedAt = new DateTime(2021, 8, 1, 14, 42, 14),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = SeedDataConstants.DirectKhachaturRazumovsky,
                Content = "Hello World",
                CreatedAt = new DateTime(2021, 8, 1, 14, 46, 29),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.KolbasatorId,
                ChatId = SeedDataConstants.DirectKolbasatorRazumovsky,
                Content = "Hello World",
                CreatedAt = new DateTime(2021, 8, 1, 14, 44, 12),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = SeedDataConstants.DirectKolbasatorRazumovsky,
                Content = "Hello World",
                CreatedAt = new DateTime(2021, 8, 1, 14, 44, 59),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.AmelitId,
                ChatId = SeedDataConstants.DirectAmelitRazumovsky,
                Content = "Hello World",
                CreatedAt = new DateTime(2021, 8, 1, 14, 21, 5),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.RazumovskyId,
                ChatId = SeedDataConstants.DirectAmelitRazumovsky,
                Content = "Hello World",
                CreatedAt = new DateTime(2021, 8, 1, 14, 31, 23),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.KhachaturId,
                ChatId = SeedDataConstants.DirectKhachaturKolbasator,
                Content = "Hello World",
                CreatedAt = new DateTime(2021, 8, 1, 14, 21, 5),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.KolbasatorId,
                ChatId = SeedDataConstants.DirectKhachaturKolbasator,
                Content = "Hello World",
                CreatedAt = new DateTime(2021, 8, 1, 14, 31, 23),
            },
            new MessageEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.PetroId,
                ChatId = SeedDataConstants.DirectPetroSzymon,
                Content = "Hi teacher",
                CreatedAt = new DateTime(2021, 8, 1, 14, 31, 23),
            }
        };

        public static List<UserContactEntity> Contacts => new()
        {
            // Petro Contacts
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.SzymonId,
                UserId = SeedDataConstants.PetroId,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.IlliaId,
                UserId = SeedDataConstants.PetroId,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.ArslanbekId,
                UserId = SeedDataConstants.PetroId,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.SerhiiId,
                UserId = SeedDataConstants.PetroId,
            },

            // Szymon Contacts
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.PetroId,
                UserId = SeedDataConstants.SzymonId,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.IlliaId,
                UserId = SeedDataConstants.SzymonId,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.ArslanbekId,
                UserId = SeedDataConstants.SzymonId,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.SerhiiId,
                UserId = SeedDataConstants.SzymonId,
            },

            // Illia Contacts
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.PetroId,
                UserId = SeedDataConstants.IlliaId,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.SzymonId,
                UserId = SeedDataConstants.IlliaId,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.ArslanbekId,
                UserId = SeedDataConstants.IlliaId,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.SerhiiId,
                UserId = SeedDataConstants.IlliaId,
            },

            // Serhii Contacts
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.PetroId,
                UserId = SeedDataConstants.SerhiiId,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.SzymonId,
                UserId = SeedDataConstants.SerhiiId,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.ArslanbekId,
                UserId = SeedDataConstants.SerhiiId,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.IlliaId,
                UserId = SeedDataConstants.SerhiiId,
            },

            // Arslanbek Contacts
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.PetroId,
                UserId = SeedDataConstants.ArslanbekId,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.SzymonId,
                UserId = SeedDataConstants.ArslanbekId,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.SerhiiId,
                UserId = SeedDataConstants.ArslanbekId,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.IlliaId,
                UserId = SeedDataConstants.ArslanbekId,
            },

            // Khachatur Contacts
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.RazumovskyId,
                UserId = SeedDataConstants.KhachaturId,
            },

            // Razumovsky Contacts
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.KhachaturId,
                UserId = SeedDataConstants.RazumovskyId,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.SzymonId,
                UserId = SeedDataConstants.RazumovskyId,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.IlliaId,
                UserId = SeedDataConstants.RazumovskyId,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.KolbasatorId,
                UserId = SeedDataConstants.RazumovskyId,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.AmelitId,
                UserId = SeedDataConstants.RazumovskyId,
            },

            // Kolbasator Contacts
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.KhachaturId,
                UserId = SeedDataConstants.KolbasatorId,
            },

            // Amelit Contacts
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.RazumovskyId,
                UserId = SeedDataConstants.AmelitId,
            }
        };
    }
}
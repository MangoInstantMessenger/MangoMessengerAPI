using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

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
        public static List<UserEntity> Users => new()
        {
            new UserEntity
            {
                Id = "1",
                DisplayName = "Petro",
                Email = "kolosovp99@gmail.com",
                NormalizedEmail = "KOLOSOVP94@GMAIL.COM",
                PhoneNumber = "+1 987 65 43 21",
                PhoneNumberConfirmed = true,
            },
            new UserEntity
            {
                Id = "2",
                DisplayName = "Szymon",
                Email = "szymon.murawski@wp.pl",
                PhoneNumber = "+1 234 45 67",
                ConfirmationCode = 524675,
            },
            new UserEntity
            {
                Id = "3",
                DisplayName = "Razumovsky",
                Email = "kolosovp95@gmail.com",
                NormalizedEmail = "KOLOSOVP95@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumber = "+1 234 45 67",
                ConfirmationCode = 154783,
            },
        };

        public static List<UserInformationEntity> UserInfo => new()
        {
            new UserInformationEntity
            {
                Id = "4",
                UserId = "1",
                FirstName = "Szymon",
                LastName = "Murawski",
                BirthDay = new DateTime(1985, 7, 24),
                Address = "Poland, Krakov",
                Facebook = "szymon.murawski",
                Instagram = "szymon.murawski",
                LinkedIn = "szymon.murawski",
                ProfilePicture = "image.png",
            },
            new UserInformationEntity
            {
                Id = "5",
                UserId = "2",
                FirstName = "Petro",
                LastName = "Kolosov",
                BirthDay = new DateTime(1994, 4, 6),
                Address = "Poland, Lvov",
                Facebook = "petro.kolosov",
                Instagram = "petro.kolosov",
                LinkedIn = "petro.kolosov",
                ProfilePicture = "petro.png",
            },
        };

        public static List<SessionEntity> UserSessions => new()
        {
            new SessionEntity
            {
                Id = "1",
                UserId = "1",
                RefreshToken = "69dbef09-de5a-4da7-9d67-abeba1510118",
                CreatedAt = DateTime.UtcNow,
                ExpiresAt = DateTime.UtcNow.AddDays(3),
            },
            new SessionEntity
            {
                Id = "2",
                UserId = "24",
                RefreshToken = "219d9df3-9bc0-4679-baaa-c18b1c7524e8",
                CreatedAt = DateTime.UtcNow,
                ExpiresAt = DateTime.UtcNow.AddDays(3),
            },
        };

        public static List<ChatEntity> Chats => new()
        {
            new ChatEntity
            {
                ChatType = ChatType.PublicChannel,
                Title = "Extreme Code Main",
                Id = "1",
            },
            new ChatEntity
            {
                ChatType = ChatType.PrivateChannel,
                Title = "Extreme Code C++",
                Id = "2",
            },
            new ChatEntity
            {
                ChatType = ChatType.ReadOnlyChannel,
                Title = "Extreme Code",
                Id = "3",
            },
            new ChatEntity
            {
                ChatType = ChatType.PrivateChannel,
                Title = "Extreme Code Flood",
                Id = "4",
            },
            new ChatEntity
            {
                ChatType = ChatType.DirectChat,
                Title = "Petro / Szymon",
                Id = "5"
            }
        };

        public static List<UserChatEntity> UserChats => new()
        {
            new UserChatEntity
            {
                ChatId = "3",
                UserId = "1",
                RoleId = UserRole.User,
            },
            new UserChatEntity
            {
                ChatId = "3",
                UserId = "2",
                RoleId = UserRole.User,
            },
            new UserChatEntity
            {
                ChatId = "4",
                UserId = "1",
                RoleId = UserRole.User,
            },
            new UserChatEntity
            {
                ChatId = "4",
                UserId = "2",
                RoleId = UserRole.User,
            },
        };

        public static List<MessageEntity> Messages => new()
        {
            new MessageEntity
            {
                Id = "1",
                ChatId = "3",
                UserId = "1",
                Content = "hello world 1",
            },
            new MessageEntity
            {
                Id = "2",
                ChatId = "3",
                UserId = "2",
                Content = "hello world 2",
            },
            new MessageEntity
            {
                Id = "3",
                ChatId = "4",
                UserId = "1",
                Content = "hello world 3",
            },
            new MessageEntity
            {
                Id = "4",
                ChatId = "4",
                UserId = "2",
                Content = "hello world 4",
            },
        };

        public static List<UserContactEntity> Contacts => new()
        {
            new UserContactEntity
            {
                Id = "1",
                UserId = "1",
                ContactId = "2",
            },
            new UserContactEntity
            {
                Id = "2",
                UserId = "2",
                ContactId = "1",
            },
        };
    }
}
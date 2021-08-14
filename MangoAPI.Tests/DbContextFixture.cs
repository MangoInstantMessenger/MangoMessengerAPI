using System;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Tests
{
    public class DbContextFixture : IDisposable
    {
        public MangoPostgresDbContext PostgresDbContext { get; }

        public DbContextFixture()
        {
            var options = new DbContextOptionsBuilder<MangoPostgresDbContext>()
                .UseInMemoryDatabase("MangoApiDatabase")
                .Options;

            PostgresDbContext = new MangoPostgresDbContext(options);
            PostgresDbContext.Database.EnsureDeleted();
            SeedUsers();
            SeedChats();
            SeedUserChat();
            SeedMessages();
        }

        private void SeedUsers()
        {
            PostgresDbContext.Users.AddRange(new UserEntity
            {
                Id = "1",
                DisplayName = "Bob"
            }, new UserEntity
            {
                Id = "2",
                DisplayName = "Alice"
            });

            PostgresDbContext.SaveChanges();
        }

        private void SeedChats()
        {
            PostgresDbContext.Chats.AddRange(
                new ChatEntity
                {
                    ChatType = ChatType.PublicChannel,
                    Title = "Extreme Code",
                    Id = "3"
                },
                new ChatEntity
                {
                    ChatType = ChatType.PublicChannel,
                    Title = "Extreme Code Flood",
                    Id = "4"
                }
            );

            PostgresDbContext.SaveChanges();
        }

        private void SeedUserChat()
        {
            PostgresDbContext.UserChats.AddRange(
                new UserChatEntity
                {
                    ChatId = "3",
                    UserId = "1",
                    RoleId = UserRole.User
                },
                new UserChatEntity
                {
                    ChatId = "3",
                    UserId = "2",
                    RoleId = UserRole.User
                },
                new UserChatEntity
                {
                    ChatId = "4",
                    UserId = "1",
                    RoleId = UserRole.User
                },
                new UserChatEntity
                {
                    ChatId = "4",
                    UserId = "2",
                    RoleId = UserRole.User
                }
            );

            PostgresDbContext.SaveChanges();
        }

        private void SeedMessages()
        {
            PostgresDbContext.Messages.AddRange(
                new MessageEntity
                {
                    Id = "5",
                    ChatId = "3",
                    UserId = "1",
                    Content = "hello world"
                },
                new MessageEntity
                {
                    Id = "6",
                    ChatId = "3",
                    UserId = "2",
                    Content = "hello world"
                },
                new MessageEntity
                {
                    Id = "7",
                    ChatId = "4",
                    UserId = "1",
                    Content = "hello world"
                },
                new MessageEntity
                {
                    Id = "8",
                    ChatId = "4",
                    UserId = "2",
                    Content = "hello world"
                }
            );
        }

        public void Dispose()
        {
            PostgresDbContext.Database.EnsureDeleted();
            PostgresDbContext.Dispose();
        }
    }
}
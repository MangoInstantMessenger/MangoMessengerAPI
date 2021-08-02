using System.Reflection;
using MangoAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.Database
{
    public class MangoPostgresDbContext : IdentityDbContext<UserEntity>
    {
        public DbSet<RefreshTokenEntity> RefreshTokens { get; set; }
        public DbSet<ChatEntity> Chats { get; set; }
        public DbSet<MessageEntity> Messages { get; set; }
        public DbSet<UserChatEntity> UserChats { get; set; }
        public DbSet<UserContactEntity> UserContacts { get; set; }
        public DbSet<UserInformationEntity> UserInformation { get; set; }
        
        
        public MangoPostgresDbContext()
        {
        }

        public MangoPostgresDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
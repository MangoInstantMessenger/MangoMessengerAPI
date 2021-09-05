using System.Reflection;
using MangoAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.DataAccess.Database
{
    public class MangoPostgresDbContext : IdentityDbContext<UserEntity>
    {
        public MangoPostgresDbContext()
        {
        }

        public MangoPostgresDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<SessionEntity> Sessions { get; set; }

        public DbSet<ChatEntity> Chats { get; set; }

        public DbSet<MessageEntity> Messages { get; set; }

        public DbSet<UserChatEntity> UserChats { get; set; }

        public DbSet<UserContactEntity> UserContacts { get; set; }

        public DbSet<UserInformationEntity> UserInformation { get; set; }
        
        public DbSet<PasswordRestoreRequestEntity> PasswordRestoreRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

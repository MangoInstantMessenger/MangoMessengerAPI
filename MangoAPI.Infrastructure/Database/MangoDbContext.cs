using System.Reflection;
using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.Database;

public class MangoDbContext : DbContext
{
    public const string DefaultSchema = "mango";

    public MangoDbContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<UserEntity> Users { get; set; }

    public DbSet<SessionEntity> Sessions { get; set; }

    public DbSet<ChatEntity> Chats { get; set; }

    public DbSet<MessageEntity> Messages { get; set; }

    public DbSet<UserChatEntity> UserChats { get; set; }

    public DbSet<ContactEntity> UserContacts { get; set; }

    public DbSet<PersonalInformationEntity> PersonalInformation { get; set; }

    public DbSet<DiffieHellmanParameterEntity> DiffieHellmanParameterEntities { get; set; }

    public DbSet<DiffieHellmanKeyExchangeEntity> DiffieHellmanKeyExchangeEntities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
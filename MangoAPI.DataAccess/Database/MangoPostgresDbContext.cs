using MangoAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

namespace MangoAPI.DataAccess.Database;

public class MangoPostgresDbContext : IdentityDbContext<UserEntity, RoleEntity, Guid>
{
    public MangoPostgresDbContext()
    {
    }

    public MangoPostgresDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<SessionEntity> Sessions { get; set; }

    public DbSet<ChatEntity> Chats { get; set; }

    public DbSet<MessageEntity> Messages { get; set; }

    public DbSet<UserChatEntity> UserChats { get; set; }

    public DbSet<UserContactEntity> UserContacts { get; set; }

    public DbSet<UserInformationEntity> UserInformation { get; set; }

    public DbSet<PasswordRestoreRequestEntity> PasswordRestoreRequests { get; set; }

    public DbSet<DocumentEntity> Documents { get; set; }

    public DbSet<CngKeyExchangeRequestEntity> CngKeyExchangeRequests { get; set; }

    public DbSet<CngPublicKeyEntity> CngPublicKeys { get; set; }
    
    public DbSet<OpenSslDhParameterEntity> OpenSslDhParameters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.LogTo(Console.WriteLine);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
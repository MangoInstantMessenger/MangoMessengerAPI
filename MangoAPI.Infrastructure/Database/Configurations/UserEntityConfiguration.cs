using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.Infrastructure.Database.Configurations;

public class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.ToTable(nameof(UserEntity), MangoDbContext.DefaultSchema);

        builder.HasKey(x => x.Id);

        builder.HasIndex(x => x.Username).IsUnique();

        builder.Property(x => x.Username).HasMaxLength(50).IsRequired();
        builder.Property(x => x.PasswordSalt).IsRequired();
        builder.Property(x => x.PasswordHash).IsRequired();
        builder.Property(x => x.DisplayName).HasMaxLength(50);
        builder.Property(x => x.ImageFileName).HasMaxLength(100).IsRequired();
        builder.Property(x => x.Bio).HasMaxLength(120);

        builder.HasMany(x => x.Sessions)
            .WithOne(x => x.UserEntity)
            .HasForeignKey(x => x.UserId);

        builder.HasOne(x => x.UserInformation)
            .WithOne(x => x.User)
            .HasForeignKey<UserInformationEntity>(x => x.UserId);

        builder.HasMany(x => x.Contacts)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.UserId);
    }
}
using System;
using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.DataAccess.Database.Extensions
{
    public static class UserEntityDbSetExtensions
    {
        public static async Task<UserEntity> FindUserByIdAsync(this DbSet<UserEntity> dbSet, 
            Guid userId, CancellationToken cancellationToken)
        {
            return await dbSet.FirstOrDefaultAsync(x => x.Id == userId, cancellationToken);
        }

        public static async Task<UserEntity> FindUserByEmailOrPhoneAsync(this DbSet<UserEntity> dbSet, 
            string phoneOrEmail, CancellationToken cancellationToken)
        {
            return await dbSet
                .FirstOrDefaultAsync(x => x.PhoneNumber == phoneOrEmail || x.Email == phoneOrEmail, 
                    cancellationToken);
        }

        public static async Task<UserEntity> FindUserByIdIncludeInfoAsync(this DbSet<UserEntity> dbSet, 
            Guid userId, CancellationToken cancellationToken)
        {
            return await dbSet
                .Include(x => x.UserInformation)
                .FirstOrDefaultAsync(x => x.Id == userId, cancellationToken);
        }
    }
}
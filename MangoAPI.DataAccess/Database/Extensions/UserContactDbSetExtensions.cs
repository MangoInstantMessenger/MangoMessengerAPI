using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.DataAccess.Database.Extensions
{
    public static class UserContactDbSetExtensions
    {
        public static async Task<List<UserContactEntity>> GetUserContactsAsync(this DbSet<UserContactEntity> dbSet,
            Guid userId, CancellationToken cancellationToken)
        {
            return await dbSet
                .Where(x => x.UserId == userId)
                .ToListAsync(cancellationToken);
        }

        public static async Task<bool> IsContactExistAsync(this DbSet<UserContactEntity> dbSet,
            Guid userId, Guid contactId, CancellationToken cancellationToken)
        {
            return await dbSet.AsNoTracking()
                .Where(x => x.UserId == userId)
                .AnyAsync(x => x.ContactId == contactId, cancellationToken);
        }
    }
}
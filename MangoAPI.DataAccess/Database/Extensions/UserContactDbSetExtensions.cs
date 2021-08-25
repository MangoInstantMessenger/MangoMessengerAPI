using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.DataAccess.Database.Extensions
{
    public static class UserContactDbSetExtensions
    {
        public static async Task<List<UserContactEntity>> GetUserContactsAsync(this DbSet<UserContactEntity> dbSet,
            string userId, CancellationToken cancellationToken)
        {
            return await dbSet
                .Where(x => x.UserId == userId)
                .ToListAsync(cancellationToken);
        }
        
        public static async Task<bool> IsContactExistAsync(this DbSet<UserContactEntity> dbSet,
            string userId, string contactId, CancellationToken cancellationToken)
        {
            return await dbSet
                .Where(x => x.UserId == userId)
                .AnyAsync(x => x.ContactId == contactId, cancellationToken);
        }
    }
}
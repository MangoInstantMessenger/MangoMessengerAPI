using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.DataAccess.Database.Extensions
{
    public static class PasswordRestoreRequestEntityDbSetExtensions
    {
        public static async Task<PasswordRestoreRequestEntity> FindPasswordRestoreRequestByIdAsync(
            this DbSet<PasswordRestoreRequestEntity> dbSet, Guid requestId, CancellationToken cancellationToken)
        {
            return await dbSet.FirstOrDefaultAsync(entity => entity.Id == requestId, cancellationToken);
        }
    }
}
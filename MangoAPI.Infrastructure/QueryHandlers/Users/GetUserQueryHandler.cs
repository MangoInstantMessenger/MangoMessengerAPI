using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Constants;
using MangoAPI.DTO.ApiQueries.Users;
using MangoAPI.DTO.Responses.Users;
using MangoAPI.Infrastructure.BusinessExceptions;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.QueryHandlers.Users
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, GetUserResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public GetUserQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GetUserResponse> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            await using var transaction = await _postgresDbContext.Database.BeginTransactionAsync(cancellationToken);
            try
            {
                var user = await _postgresDbContext.Users.AsNoTracking()
                    .FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);

                return user == null
                    ? throw new BusinessException(ResponseMessageCodes.UserNotFound)
                    : GetUserResponse.FromSuccess(user);
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync(cancellationToken);
                throw new BusinessException(ResponseMessageCodes.DatabaseError);
            }
        }
    }
}
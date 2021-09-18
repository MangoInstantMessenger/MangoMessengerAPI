using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.ApiQueries.Users
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
            var user = await _postgresDbContext.Users.AsNoTracking().Include(x => x.UserInformation)
                .FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            return GetUserResponse.FromSuccess(user);
        }
    }
}
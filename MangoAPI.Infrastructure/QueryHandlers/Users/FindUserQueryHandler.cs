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
    public class FindUserQueryHandler : IRequestHandler<GetUserByIdQuery, FindUserResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public FindUserQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<FindUserResponse> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.FirstOrDefaultAsync(x => x.Id == request.UserId,
                cancellationToken);

            return user == null
                ? throw new BusinessException(ResponseMessageCodes.UserNotFound)
                : FindUserResponse.FromSuccess(user);
        }
    }
}
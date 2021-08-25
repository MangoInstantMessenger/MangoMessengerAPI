namespace MangoAPI.BusinessLogic.ApiQueries.Users
{
    using System.Threading;
    using System.Threading.Tasks;
    using BusinessExceptions;
    using DataAccess.Database;
    using DataAccess.Database.Extensions;
    using Domain.Constants;
    using MediatR;

    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, GetUserResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public GetUserQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GetUserResponse> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.FindUserByIdIncludeInfoAsync(request.UserId, cancellationToken);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }
            
            return GetUserResponse.FromSuccess(user);
        }
    }
}

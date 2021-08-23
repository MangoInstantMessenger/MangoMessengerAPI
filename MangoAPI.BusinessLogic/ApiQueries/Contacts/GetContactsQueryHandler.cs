namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using BusinessExceptions;
    using DataAccess.Database;
    using Domain.Constants;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    public class GetContactsQueryHandler : IRequestHandler<GetContactsQuery, GetContactsResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public GetContactsQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GetContactsResponse> Handle(GetContactsQuery request, CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users
                .FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var contacts = await (from userContact in _postgresDbContext.UserContacts.AsNoTracking()
                join userEntity in _postgresDbContext.Users.Include(x => x.UserInformation)
                    on userContact.ContactId equals userEntity.Id
                where userContact.UserId == request.UserId
                select userEntity).ToListAsync(cancellationToken);

            return GetContactsResponse.FromSuccess(contacts);
        }
    }
}

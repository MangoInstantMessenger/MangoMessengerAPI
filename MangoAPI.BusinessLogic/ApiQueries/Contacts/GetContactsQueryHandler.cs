using MangoAPI.DataAccess.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
    public class GetContactsQueryHandler : IRequestHandler<GetContactsQuery, GetContactsResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public GetContactsQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GetContactsResponse> Handle(GetContactsQuery request, CancellationToken cancellationToken)
        {
            var contacts = await (from userContact in _postgresDbContext.UserContacts.AsNoTracking()
                                  join userEntity in _postgresDbContext.Users.AsNoTracking().Include(x => x.UserInformation)
                                      on userContact.ContactId equals userEntity.Id
                                  where userContact.UserId == request.UserId
                                  orderby userContact.CreatedAt
                                  select userEntity).ToListAsync(cancellationToken);

            return GetContactsResponse.FromSuccess(contacts);
        }
    }
}
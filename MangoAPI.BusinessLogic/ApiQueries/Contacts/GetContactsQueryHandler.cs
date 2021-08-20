namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using MangoAPI.BusinessLogic.BusinessExceptions;
    using MangoAPI.DataAccess.Database;
    using MangoAPI.Domain.Constants;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    public class GetContactsQueryHandler : IRequestHandler<GetContactsQuery, GetContactsResponse>
    {
        private readonly MangoPostgresDbContext postgresDbContext;

        public GetContactsQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            this.postgresDbContext = postgresDbContext;
        }

        public async Task<GetContactsResponse> Handle(GetContactsQuery request, CancellationToken cancellationToken)
        {
            var user = await postgresDbContext.Users
                .FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var contacts = await (from userContact in postgresDbContext.UserContacts.AsNoTracking()
                join userEntity in postgresDbContext.Users.Include(x => x.UserInformation)
                    on userContact.ContactId equals userEntity.Id
                where userContact.UserId == request.UserId
                select userEntity).ToListAsync(cancellationToken);

            return GetContactsResponse.FromSuccess(contacts);
        }
    }
}

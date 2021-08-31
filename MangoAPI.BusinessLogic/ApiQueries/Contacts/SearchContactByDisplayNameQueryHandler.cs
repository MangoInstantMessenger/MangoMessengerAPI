using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.DataAccess.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
    public class
        SearchContactByDisplayNameQueryHandler : IRequestHandler<SearchContactByDisplayNameQuery,
            SearchContactByDisplayNameResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public SearchContactByDisplayNameQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<SearchContactByDisplayNameResponse> Handle(SearchContactByDisplayNameQuery request,
            CancellationToken cancellationToken)
        {
            var users = await _postgresDbContext.Users
                .AsNoTracking()
                .Include(x => x.UserInformation)
                .ToListAsync(cancellationToken);

            if (!string.IsNullOrEmpty(request.DisplayName) || !string.IsNullOrWhiteSpace(request.DisplayName))
            {
                users = users.Where(x => x.DisplayName.ToUpper().Contains(request.DisplayName.ToUpper()))
                    .ToList();
            }

            var contacts = users.Select(x => new Contact
            {
                UserId = x.Id,
                DisplayName = x.DisplayName,
                Address = x.UserInformation.Address,
                Bio = x.Bio,
            }).ToList();

            foreach (var contact in contacts)
            {
                var isContact = await _postgresDbContext.UserContacts
                    .AnyAsync(x => x.UserId == request.UserId && x.ContactId == contact.UserId, cancellationToken);

                contact.IsContact = isContact;
            }

            return SearchContactByDisplayNameResponse.FromSuccess(contacts);
        }
    }
}
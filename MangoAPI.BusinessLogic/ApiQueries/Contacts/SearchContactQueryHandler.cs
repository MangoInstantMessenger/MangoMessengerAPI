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
        SearchContactByDisplayNameQueryHandler : IRequestHandler<SearchContactQuery,
            SearchContactResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public SearchContactByDisplayNameQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<SearchContactResponse> Handle(SearchContactQuery request,
            CancellationToken cancellationToken)
        {
            var users = await _postgresDbContext.Users
                .AsNoTracking()
                .Include(x => x.UserInformation)
                .ToListAsync(cancellationToken);

            if (!string.IsNullOrEmpty(request.SearchQuery) || !string.IsNullOrWhiteSpace(request.SearchQuery))
            {
                users = users.Where(x => x.DisplayName.ToUpper().Contains(request.SearchQuery.ToUpper())
                                         || x.Email.ToUpper().Contains(request.SearchQuery.ToUpper())
                                         || x.PhoneNumber.ToUpper().Contains(request.SearchQuery.ToUpper())).ToList();
            }

            var contacts = users.Select(x => new Contact
            {
                UserId = x.Id,
                DisplayName = x.DisplayName,
                Address = x.UserInformation.Address,
                Bio = x.Bio,
                PictureUrl = x.PictureUrl,
            }).ToList();

            foreach (var contact in contacts)
            {
                var isContact = await _postgresDbContext.UserContacts
                    .AnyAsync(x => x.UserId == request.UserId && x.ContactId == contact.UserId, cancellationToken);

                contact.IsContact = isContact;
            }

            return SearchContactResponse.FromSuccess(contacts);
        }
    }
}
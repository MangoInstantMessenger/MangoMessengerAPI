using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
    public class SearchContactByDisplayNameQueryHandler 
        : IRequestHandler<SearchContactQuery, Result<SearchContactResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly ResponseFactory<SearchContactResponse> _responseFactory;
        private readonly StringService _stringService;

        public SearchContactByDisplayNameQueryHandler(MangoPostgresDbContext postgresDbContext,
            ResponseFactory<SearchContactResponse> responseFactory, StringService stringService)
        {
            _postgresDbContext = postgresDbContext;
            _responseFactory = responseFactory;
            _stringService = stringService;
        }

        public async Task<Result<SearchContactResponse>> Handle(SearchContactQuery request,
            CancellationToken cancellationToken)
        {
            var query = _postgresDbContext.Users
                .AsNoTracking()
                .Include(x => x.UserInformation)
                .Where(x => x.Id != request.UserId)
                .Select(x => new Contact
                {
                    UserId = x.Id,
                    DisplayName = x.DisplayName,
                    Address = x.UserInformation.Address,
                    Bio = x.Bio,
                    PictureUrl = _stringService.GetDocumentUrl(x.Image),
                    Email = x.Email,
                });

            if (!string.IsNullOrEmpty(request.SearchQuery) || !string.IsNullOrWhiteSpace(request.SearchQuery))
            {
                query = query.Where(x => 
                    x.DisplayName.Contains(request.SearchQuery) ||
                    x.Email.Contains(request.SearchQuery));
            }

            var searchResult = await query.Take(200).ToListAsync(cancellationToken);

            var commonContacts = await _postgresDbContext.UserContacts.AsNoTracking()
                .Where(x => x.UserId == request.UserId)
                .Select(x => x.ContactId)
                .ToListAsync(cancellationToken);

            foreach (var contact in searchResult)
            {
                contact.IsContact = commonContacts.Contains(contact.UserId);
            }

            return _responseFactory.SuccessResponse(SearchContactResponse.FromSuccess(searchResult));
        }
    }
}
﻿using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
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
                .Where(x => x.Id != request.UserId)
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
                PictureUrl = StringService.GetDocumentUrl(x.Image),
            }).ToList();

            var contactsUserIds = contacts.Select(x => x.UserId);

            var commonContacts = await _postgresDbContext.UserContacts.AsNoTracking()
                .Where(x => x.UserId == request.UserId && contactsUserIds.Contains(x.UserId))
                .Select(x => x.UserId)
                .ToListAsync(cancellationToken);

            foreach (var contact in contacts)
            {
                contact.IsContact = commonContacts.Contains(contact.UserId);
            }

            return SearchContactResponse.FromSuccess(contacts);
        }
    }
}
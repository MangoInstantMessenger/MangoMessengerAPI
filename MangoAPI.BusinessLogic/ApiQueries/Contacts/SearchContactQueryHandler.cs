using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts;

public class SearchContactByDisplayNameQueryHandler
    : IRequestHandler<SearchContactQuery, Result<SearchContactResponse>>
{
    private readonly MangoPostgresDbContext _postgresDbContext;
    private readonly ResponseFactory<SearchContactResponse> _responseFactory;

    public SearchContactByDisplayNameQueryHandler(
        MangoPostgresDbContext postgresDbContext,
        ResponseFactory<SearchContactResponse> responseFactory)
    {
        _postgresDbContext = postgresDbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<SearchContactResponse>> Handle(SearchContactQuery request,
        CancellationToken cancellationToken)
    {
        IQueryable<Contact> query;

        var isRelational = _postgresDbContext.Database.IsRelational();

        if (isRelational)
        {
            query = _postgresDbContext.Users
                .AsNoTracking()
                .Include(x => x.UserInformation)
                .Where(x => x.Id != request.UserId)
                .Where(x => EF.Functions.ILike(x.DisplayName, $"%{request.SearchQuery}%"))
                .Select(x => new Contact
                {
                    UserId = x.Id,
                    DisplayName = x.DisplayName,
                    Address = x.UserInformation.Address,
                    Bio = x.Bio,
                    PictureUrl = StringService.GetDocumentUrl(x.Image),
                    Email = x.Email,
                });
        }
        else
        {
            query = _postgresDbContext.Users
                .AsNoTracking()
                .Include(x => x.UserInformation)
                .Where(x => x.Id != request.UserId)
                .Where(x => x.DisplayName.Contains(request.SearchQuery))
                .Select(x => new Contact
                {
                    UserId = x.Id,
                    DisplayName = x.DisplayName,
                    Address = x.UserInformation.Address,
                    Bio = x.Bio,
                    PictureUrl = StringService.GetDocumentUrl(x.Image),
                    Email = x.Email,
                });
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
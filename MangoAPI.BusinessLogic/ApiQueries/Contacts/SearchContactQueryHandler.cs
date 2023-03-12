using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts;

public class SearchContactByDisplayNameQueryHandler
    : IRequestHandler<SearchContactQuery, Result<SearchContactResponse>>
{
    private readonly MangoDbContext dbContext;
    private readonly ResponseFactory<SearchContactResponse> responseFactory;
    private readonly IBlobServiceSettings blobServiceSettings;

    public SearchContactByDisplayNameQueryHandler(
        MangoDbContext dbContext,
        ResponseFactory<SearchContactResponse> responseFactory,
        IBlobServiceSettings blobServiceSettings)
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
        this.blobServiceSettings = blobServiceSettings;
    }

    public async Task<Result<SearchContactResponse>> Handle(
        SearchContactQuery request,
        CancellationToken cancellationToken)
    {
        var query = dbContext.Users
            .AsNoTracking()
            .Include(x => x.UserInformation)
            .Where(x => x.Id != request.UserId)
            .Where(x => EF.Functions.Like(x.DisplayName, $"%{request.SearchQuery}%"))
            .Select(x => new Contact
            {
                UserId = x.Id,
                DisplayName = x.DisplayName,
                Address = x.UserInformation.Address,
                Bio = x.Bio,
                PictureUrl = $"{blobServiceSettings.MangoBlobAccess}/{x.Image}",
                Username = x.Username,
            });

        var searchResult = await query.Take(200).ToListAsync(cancellationToken);

        var commonContacts = await dbContext.UserContacts.AsNoTracking()
            .Where(x => x.UserId == request.UserId)
            .Select(x => x.ContactId)
            .ToListAsync(cancellationToken);

        foreach (var contact in searchResult)
        {
            contact.IsContact = commonContacts.Contains(contact.UserId);
        }

        return responseFactory.SuccessResponse(SearchContactResponse.FromSuccess(searchResult));
    }
}
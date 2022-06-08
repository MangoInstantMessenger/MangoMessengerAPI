using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts;

public class SearchContactByDisplayNameQueryHandler
    : IRequestHandler<SearchContactQuery, Result<SearchContactResponse>>
{
    private readonly MangoDbContext _dbContext;
    private readonly ResponseFactory<SearchContactResponse> _responseFactory;
    private readonly IBlobServiceSettings _blobServiceSettings;

    public SearchContactByDisplayNameQueryHandler(
        MangoDbContext dbContext,
        ResponseFactory<SearchContactResponse> responseFactory,
        IBlobServiceSettings blobServiceSettings)
    {
        _dbContext = dbContext;
        _responseFactory = responseFactory;
        _blobServiceSettings = blobServiceSettings;
    }

    public async Task<Result<SearchContactResponse>> Handle(SearchContactQuery request,
        CancellationToken cancellationToken)
    {
        var query = _dbContext.Users
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
                PictureUrl = StringService.GetDocumentUrl(x.Image, _blobServiceSettings.MangoBlobAccess),
                Email = x.Email,
            });


        var searchResult = await query.Take(200).ToListAsync(cancellationToken);

        var commonContacts = await _dbContext.UserContacts.AsNoTracking()
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
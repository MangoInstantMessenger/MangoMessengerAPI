using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Infrastructure.Database;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts;

public class GetContactsQueryHandler : IRequestHandler<GetContactsQuery, Result<GetContactsResponse>>
{
    private readonly MangoDbContext _dbContext;
    private readonly ResponseFactory<GetContactsResponse> _responseFactory;
    private readonly IBlobServiceSettings _blobServiceSettings;

    public GetContactsQueryHandler(
        MangoDbContext dbContext,
        ResponseFactory<GetContactsResponse> responseFactory,
        IBlobServiceSettings blobServiceSettings)
    {
        _dbContext = dbContext;
        _responseFactory = responseFactory;
        _blobServiceSettings = blobServiceSettings;
    }

    public async Task<Result<GetContactsResponse>> Handle(GetContactsQuery request, CancellationToken cancellationToken)
    {
        var query = from userContact in _dbContext.UserContacts.AsNoTracking()
            join userEntity in _dbContext.Users.Include(x => x.UserInformation)
                on userContact.ContactId equals userEntity.Id
            where userContact.UserId == request.UserId
            orderby userContact.CreatedAt
            select new Contact
            {
                UserId = userEntity.Id,
                DisplayName = userEntity.DisplayName,
                Address = userEntity.UserInformation.Address,
                Bio = userEntity.Bio,
                PictureUrl = StringService.GetDocumentUrl(userEntity.Image, _blobServiceSettings.MangoBlobAccess),
                Email = userEntity.Email,
                IsContact = true,
            };

        var contacts = await query.Take(200).ToListAsync(cancellationToken);

        return _responseFactory.SuccessResponse(GetContactsResponse.FromSuccess(contacts));
    }
}
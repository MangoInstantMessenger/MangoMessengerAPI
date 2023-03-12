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

public class GetContactsQueryHandler : IRequestHandler<GetContactsQuery, Result<GetContactsResponse>>
{
    private readonly MangoDbContext dbContext;
    private readonly ResponseFactory<GetContactsResponse> responseFactory;
    private readonly IBlobServiceSettings blobServiceSettings;

    public GetContactsQueryHandler(
        MangoDbContext dbContext,
        ResponseFactory<GetContactsResponse> responseFactory,
        IBlobServiceSettings blobServiceSettings)
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
        this.blobServiceSettings = blobServiceSettings;
    }

    public async Task<Result<GetContactsResponse>> Handle(GetContactsQuery request, CancellationToken cancellationToken)
    {
        var query = from userContact in dbContext.UserContacts.AsNoTracking()
            join userEntity in dbContext.Users.Include(x => x.UserInformation)
                on userContact.ContactId equals userEntity.Id
            where userContact.UserId == request.UserId
            orderby userContact.CreatedAt
            select new Contact
            {
                UserId = userEntity.Id,
                DisplayName = userEntity.DisplayName,
                Address = userEntity.UserInformation.Address,
                Bio = userEntity.Bio,
                PictureUrl = $"{blobServiceSettings.MangoBlobAccess}/{userEntity.ImageFileName}",
                Username = userEntity.Username,
                IsContact = true,
            };

        var contacts = await query.Take(200).ToListAsync(cancellationToken);

        return responseFactory.SuccessResponse(GetContactsResponse.FromSuccess(contacts));
    }
}
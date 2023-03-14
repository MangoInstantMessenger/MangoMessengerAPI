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
        var query =
            from contact in dbContext.UserContacts.AsNoTracking()
            join userEntity in dbContext.Users on contact.ContactId equals userEntity.Id
            where contact.UserId == request.UserId
            select new Contact
            {
                UserId = userEntity.Id,
                DisplayName = userEntity.DisplayName,
                Address = userEntity.Address,
                Bio = userEntity.Bio,
                PictureUrl = $"{blobServiceSettings.MangoBlobAccess}/{userEntity.ImageFileName}",
                Username = userEntity.Username,
                IsContact = true,
                CreatedAt = contact.CreatedAt
            };

        var contacts = await query.Take(200).OrderByDescending(x => x.CreatedAt).ToListAsync(cancellationToken);

        return responseFactory.SuccessResponse(GetContactsResponse.FromSuccess(contacts));
    }
}
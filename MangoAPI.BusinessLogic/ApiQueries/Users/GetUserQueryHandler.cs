using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.Users;

public class GetUserQueryHandler : IRequestHandler<GetUserQuery, Result<GetUserResponse>>
{
    private readonly MangoDbContext dbContext;
    private readonly ResponseFactory<GetUserResponse> responseFactory;
    private readonly IBlobServiceSettings blobServiceSettings;

    public GetUserQueryHandler(
        MangoDbContext dbContext,
        ResponseFactory<GetUserResponse> responseFactory,
        IBlobServiceSettings blobServiceSettings)
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
        this.blobServiceSettings = blobServiceSettings;
    }

    public async Task<Result<GetUserResponse>> Handle(
        GetUserQuery request,
        CancellationToken cancellationToken)
    {
        var user = await dbContext.Users.AsNoTracking()
            .Include(x => x.UserInformation)
            .Select(user => new User
            {
                UserId = user.Id,
                DisplayName = user.DisplayName,
                DisplayNameColour = user.DisplayNameColour,
                Address = user.UserInformation.Address,
                BirthdayDate = user.UserInformation.BirthDay.HasValue
                    ? user.UserInformation.BirthDay.Value.ToString("yyyy-MM-dd")
                    : null,
                Email = user.Email,
                Website = user.UserInformation.Website,
                Facebook = user.UserInformation.Facebook,
                Twitter = user.UserInformation.Twitter,
                Instagram = user.UserInformation.Instagram,
                LinkedIn = user.UserInformation.LinkedIn,
                Username = user.UserName,
                Bio = user.Bio,
                PictureUrl = StringService.GetDocumentUrl(user.Image, blobServiceSettings.MangoBlobAccess),
            }).FirstOrDefaultAsync(x => x.UserId == request.UserId, cancellationToken);

        if (user is null)
        {
            const string errorMessage = ResponseMessageCodes.UserNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }

        return responseFactory.SuccessResponse(GetUserResponse.FromSuccess(user));
    }
}

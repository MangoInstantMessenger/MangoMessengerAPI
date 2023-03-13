using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

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
            .Include(x => x.PersonalInformation)
            .Select(user => new User
            {
                UserId = user.Id,
                DisplayName = user.DisplayName,
                DisplayNameColour = user.DisplayNameColour,
                Address = user.Address,
                Birthday = user.Birthday.HasValue
                    ? user.Birthday.Value.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture)
                    : null,
                Website = user.Website,
                Facebook = user.PersonalInformation.Facebook,
                Twitter = user.PersonalInformation.Twitter,
                Instagram = user.PersonalInformation.Instagram,
                LinkedIn = user.PersonalInformation.LinkedIn,
                Username = user.Username,
                Bio = user.Bio,
                PictureUrl = $"{blobServiceSettings.MangoBlobAccess}/{user.ImageFileName}",
            }).FirstOrDefaultAsync(x => x.UserId == request.UserId, cancellationToken);

        if (user == null)
        {
            const string errorMessage = ResponseMessageCodes.UserNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }

        return responseFactory.SuccessResponse(GetUserResponse.FromSuccess(user));
    }
}
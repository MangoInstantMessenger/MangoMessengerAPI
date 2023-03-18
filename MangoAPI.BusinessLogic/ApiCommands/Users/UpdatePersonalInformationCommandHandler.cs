using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Models;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class UpdatePersonalInformationCommandHandler
    : IRequestHandler<UpdatePersonalInformationCommand, Result<UpdatePersonalInformationResponse>>
{
    private readonly MangoDbContext dbContext;
    private readonly ResponseFactory<UpdatePersonalInformationResponse> responseFactory;
    private readonly IBlobServiceSettings blobServiceSettings;

    public UpdatePersonalInformationCommandHandler(
        MangoDbContext dbContext,
        ResponseFactory<UpdatePersonalInformationResponse> responseFactory,
        IBlobServiceSettings blobServiceSettings)
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
        this.blobServiceSettings = blobServiceSettings;
    }

    public async Task<Result<UpdatePersonalInformationResponse>> Handle(
        UpdatePersonalInformationCommand request,
        CancellationToken cancellationToken)
    {
        var user = await dbContext.Users.AsNoTracking()
            .Include(x => x.PersonalInformation)
            // .Select(user => new User
            // {
            //     UserId = user.Id,
            //     DisplayName = user.DisplayName,
            //     DisplayNameColour = user.DisplayNameColour,
            //     Address = user.Address,
            //     Birthday = user.Birthday.HasValue
            //         ? user.Birthday.Value.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture)
            //         : null,
            //     Website = user.Website,
            //     Facebook = user.PersonalInformation.Facebook,
            //     Twitter = user.PersonalInformation.Twitter,
            //     Instagram = user.PersonalInformation.Instagram,
            //     LinkedIn = user.PersonalInformation.LinkedIn,
            //     Username = user.Username,
            //     Bio = user.Bio,
            //     PictureUrl = $"{blobServiceSettings.MangoBlobAccess}/{user.ImageFileName}",
            // })
            .FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);

        if (user == null)
        {
            const string errorMessage = ResponseMessageCodes.UserNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }

        user.PersonalInformation.UpdateSocialInformation(
            request.Facebook,
            request.Twitter,
            request.Instagram,
            request.LinkedIn);

        dbContext.PersonalInformation.Update(user.PersonalInformation);

        await dbContext.SaveChangesAsync(cancellationToken);

        var userDto = new User
        {
            UserId = user.Id,
            DisplayName = user.DisplayName,
            DisplayNameColour = user.DisplayNameColour,
            Address = user.Address,
            Birthday = user.Birthday?.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture),
            Website = user.Website,
            Facebook = user.PersonalInformation.Facebook,
            Twitter = user.PersonalInformation.Twitter,
            Instagram = user.PersonalInformation.Instagram,
            LinkedIn = user.PersonalInformation.LinkedIn,
            Username = user.Username,
            Bio = user.Bio,
            PictureUrl = $"{blobServiceSettings.MangoBlobAccess}/{user.ImageFileName}",
        };

        var response = UpdatePersonalInformationResponse.FromSuccess(userDto);

        return responseFactory.SuccessResponse(response);
    }
}
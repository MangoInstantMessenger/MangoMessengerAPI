using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class UpdateProfilePictureCommandHandler
    : IRequestHandler<UpdateProfilePictureCommand, Result<UpdateProfilePictureResponse>>
{
    private readonly MangoDbContext dbContext;
    private readonly ResponseFactory<UpdateProfilePictureResponse> responseFactory;
    private readonly IBlobService blobService;

    public UpdateProfilePictureCommandHandler(
        MangoDbContext dbContext,
        ResponseFactory<UpdateProfilePictureResponse> responseFactory,
        IBlobService blobService)
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
        this.blobService = blobService;
    }

    public async Task<Result<UpdateProfilePictureResponse>> Handle(
        UpdateProfilePictureCommand request,
        CancellationToken cancellationToken)
    {
        var user = await dbContext.Users
            .FirstOrDefaultAsync(
                userEntity => userEntity.Id == request.UserId,
                cancellationToken);

        if (user == null)
        {
            const string errorMessage = ResponseMessageCodes.UserNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }

        var file = request.PictureFile;
        var uniqueFileName = FileNameHelper.CreateUniqueFileName(file.FileName);

        await blobService.UploadFileBlobAsync(file.OpenReadStream(), request.ContentType, uniqueFileName);

        user.UpdateProfilePicture(uniqueFileName);

        dbContext.Users.Update(user);

        await dbContext.SaveChangesAsync(cancellationToken);

        var newUserPictureUrl = blobService.GetBlobAsync(uniqueFileName);
        var response = UpdateProfilePictureResponse.FromSuccess(newUserPictureUrl, uniqueFileName);

        return responseFactory.SuccessResponse(response);
    }
}
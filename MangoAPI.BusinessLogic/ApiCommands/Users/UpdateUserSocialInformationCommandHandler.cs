using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class UpdateUserSocialInformationCommandHandler
    : IRequestHandler<UpdateUserSocialInformationCommand, Result<ResponseBase>>
{
    private readonly MangoDbContext dbContext;
    private readonly ResponseFactory<ResponseBase> responseFactory;

    public UpdateUserSocialInformationCommandHandler(
        MangoDbContext dbContext,
        ResponseFactory<ResponseBase> responseFactory)
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(
        UpdateUserSocialInformationCommand request,
        CancellationToken cancellationToken)
    {
        var personalInformation = await dbContext.PersonalInformation
            .FirstOrDefaultAsync(
                entity => entity.UserId == request.UserId,
                cancellationToken);

        if (personalInformation == null)
        {
            const string errorMessage = ResponseMessageCodes.UserNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }

        // personalInformation.Facebook = request.Facebook;
        // personalInformation.Twitter = request.Twitter;
        // personalInformation.Instagram = request.Instagram;
        // personalInformation.LinkedIn = request.LinkedIn;
        // personalInformation.UpdatedAt = DateTime.UtcNow;

        personalInformation.UpdateSocialInformation(
            request.Facebook,
            request.Twitter,
            request.Instagram,
            request.LinkedIn);

        dbContext.PersonalInformation.Update(personalInformation);

        await dbContext.SaveChangesAsync(cancellationToken);

        return responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
    }
}
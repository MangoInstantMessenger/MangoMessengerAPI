using System;
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

    public UpdateUserSocialInformationCommandHandler(MangoDbContext dbContext,
        ResponseFactory<ResponseBase> responseFactory)
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(UpdateUserSocialInformationCommand request,
        CancellationToken cancellationToken)
    {
        var user = await dbContext.Users
            .Include(userEntity => userEntity.UserInformation)
            .FirstOrDefaultAsync(entity => entity.Id == request.UserId,
                cancellationToken);

        if (user is null)
        {
            const string errorMessage = ResponseMessageCodes.UserNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }

        user.UserInformation.Facebook = request.Facebook;
        user.UserInformation.Twitter = request.Twitter;
        user.UserInformation.Instagram = request.Instagram;
        user.UserInformation.LinkedIn = request.LinkedIn;

        user.UserInformation.UpdatedAt = DateTime.UtcNow;

        dbContext.UserInformation.Update(user.UserInformation);

        await dbContext.SaveChangesAsync(cancellationToken);

        return responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
    }
}

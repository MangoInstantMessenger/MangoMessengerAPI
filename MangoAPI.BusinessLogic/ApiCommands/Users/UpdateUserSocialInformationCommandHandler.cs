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
    private readonly MangoDbContext _dbContext;
    private readonly ResponseFactory<ResponseBase> _responseFactory;

    public UpdateUserSocialInformationCommandHandler(MangoDbContext dbContext,
        ResponseFactory<ResponseBase> responseFactory)
    {
        _dbContext = dbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(UpdateUserSocialInformationCommand request,
        CancellationToken cancellationToken)
    {
        var user = await _dbContext.Users
            .Include(userEntity => userEntity.UserInformation)
            .FirstOrDefaultAsync(entity => entity.Id == request.UserId,
                cancellationToken);

        if (user is null)
        {
            const string errorMessage = ResponseMessageCodes.UserNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, details);
        }

        user.UserInformation.Facebook = request.Facebook;
        user.UserInformation.Twitter = request.Twitter;
        user.UserInformation.Instagram = request.Instagram;
        user.UserInformation.LinkedIn = request.LinkedIn;

        user.UserInformation.UpdatedAt = DateTime.UtcNow;

        _dbContext.UserInformation.Update(user.UserInformation);
            
        await _dbContext.SaveChangesAsync(cancellationToken);

        return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
    }
}
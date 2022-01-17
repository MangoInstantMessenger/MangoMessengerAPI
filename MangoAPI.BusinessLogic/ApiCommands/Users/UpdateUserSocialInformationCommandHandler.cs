using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class UpdateUserSocialInformationCommandHandler
    : IRequestHandler<UpdateUserSocialInformationCommand, Result<ResponseBase>>
{
    private readonly MangoPostgresDbContext _postgresDbContext;
    private readonly ResponseFactory<ResponseBase> _responseFactory;

    public UpdateUserSocialInformationCommandHandler(MangoPostgresDbContext postgresDbContext,
        ResponseFactory<ResponseBase> responseFactory)
    {
        _postgresDbContext = postgresDbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(UpdateUserSocialInformationCommand request,
        CancellationToken cancellationToken)
    {
        var user = await _postgresDbContext.Users
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

        _postgresDbContext.UserInformation.Update(user.UserInformation);
            
        await _postgresDbContext.SaveChangesAsync(cancellationToken);

        return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
    }
}
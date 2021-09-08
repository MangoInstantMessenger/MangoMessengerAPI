using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class
        UpdateUserSocialInformationCommandHandler : IRequestHandler<UpdateUserSocialInformationCommand, ResponseBase>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public UpdateUserSocialInformationCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<ResponseBase> Handle(UpdateUserSocialInformationCommand request,
            CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.FindUserByIdIncludeInfoAsync(request.UserId, cancellationToken);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            user.UserInformation.Facebook = StringIsValid(request.Facebook) 
                ? request.Facebook 
                : user.UserInformation.Facebook;

            user.UserInformation.Twitter = StringIsValid(request.Twitter) 
                ? request.Twitter 
                : user.UserInformation.Twitter;

            user.UserInformation.Instagram = StringIsValid(request.Instagram) 
                ? request.Instagram 
                : user.UserInformation.Instagram;

            user.UserInformation.LinkedIn = StringIsValid(request.LinkedIn) 
                ? request.LinkedIn 
                : user.UserInformation.LinkedIn;
            
            user.UserInformation.UpdatedAt = DateTime.UtcNow;

            _postgresDbContext.UserInformation.Update(user.UserInformation);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return ResponseBase.SuccessResponse;
        }

        private static bool StringIsValid(string str)
        {
            return !string.IsNullOrEmpty(str) && !string.IsNullOrWhiteSpace(str);
        }
    }
}
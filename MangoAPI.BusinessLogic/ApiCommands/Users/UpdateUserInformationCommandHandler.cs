using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class UpdateUserInformationCommandHandler : IRequestHandler<UpdateUserInformationCommand,
        UpdateUserInformationResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public UpdateUserInformationCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<UpdateUserInformationResponse> Handle(
            UpdateUserInformationCommand request,
            CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.FindUserByIdIncludeInfoAsync(request.UserId, cancellationToken);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            user.UserInformation.FirstName = request.FirstName ?? user.UserInformation.FirstName;
            user.UserInformation.LastName = request.LastName ?? user.UserInformation.LastName;
            user.DisplayName = request.DisplayName ?? user.DisplayName;
            user.PhoneNumber = request.PhoneNumber ?? user.PhoneNumber;

            user.UserInformation.BirthDay = DateTime.TryParse(request.BirthdayDate, out var newDate)
                ? newDate
                : user.UserInformation.BirthDay;

            user.Email = request.Email ?? user.Email;
            user.UserInformation.Website = request.Website ?? user.UserInformation.Website;
            user.UserName = request.Username ?? user.UserName;
            user.Bio = request.Bio ?? user.Bio;
            user.UserInformation.Address = request.Address ?? user.UserInformation.Address;
            user.UserInformation.Facebook = request.Facebook ?? user.UserInformation.Facebook;
            user.UserInformation.Twitter = request.Twitter ?? user.UserInformation.Twitter;
            user.UserInformation.Instagram = request.Instagram ?? user.UserInformation.Instagram;
            user.UserInformation.LinkedIn = request.LinkedIn ?? user.UserInformation.LinkedIn;
            user.UserInformation.UpdatedAt = DateTime.UtcNow;

            _postgresDbContext.UserInformation.Update(user.UserInformation);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return UpdateUserInformationResponse.SuccessResponse;
        }
    }
}
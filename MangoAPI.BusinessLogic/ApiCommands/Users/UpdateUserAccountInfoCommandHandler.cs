using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class UpdateUserAccountInfoCommandHandler : IRequestHandler<UpdateUserAccountInfoCommand, ResponseBase>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public UpdateUserAccountInfoCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<ResponseBase> Handle(UpdateUserAccountInfoCommand request,
            CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.FindUserByIdIncludeInfoAsync(request.UserId, cancellationToken);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            if (user.DisplayName != request.DisplayName)
            {
                var userChats = await _postgresDbContext.UserChats
                    .Include(x => x.Chat)
                    .Where(x => x.UserId == user.Id && x.Chat.CommunityType == CommunityType.DirectChat)
                    .Select(x => x.Chat)
                    .ToListAsync(cancellationToken);

                foreach (var chatEntity in userChats)
                {
                    var newTitle = chatEntity.Title.Replace(user.DisplayName, request.DisplayName);
                    chatEntity.Title = newTitle;
                }

                user.DisplayName = request.DisplayName;

                _postgresDbContext.Chats.UpdateRange(userChats);
            }

            user.UserInformation.BirthDay = DateTime.TryParse(request.BirthdayDate, out var newDate)
                ? newDate
                : user.UserInformation.BirthDay;

            user.PhoneNumber = StringIsValid(request.PhoneNumber)
                ? request.PhoneNumber
                : user.PhoneNumber;

            user.UserInformation.FirstName = StringIsValid(request.FirstName)
                ? request.FirstName
                : user.UserInformation.FirstName;

            user.UserInformation.LastName = StringIsValid(request.LastName)
                ? request.LastName
                : user.UserInformation.LastName;

            user.Email = StringIsValid(request.Email)
                ? request.Email
                : user.Email;

            user.UserInformation.Website = StringIsValid(request.Website)
                ? request.Website
                : user.UserInformation.Website;

            user.UserName = StringIsValid(request.Username)
                ? request.Username
                : user.UserName;

            user.Bio = StringIsValid(request.Bio)
                ? request.Bio
                : user.Bio;

            user.UserInformation.Address = StringIsValid(request.Address)
                ? request.Address
                : user.UserInformation.Address;

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
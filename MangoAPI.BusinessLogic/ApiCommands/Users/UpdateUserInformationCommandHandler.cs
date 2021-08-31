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
    public class UpdateUserInformationCommandHandler : IRequestHandler<UpdateUserInformationCommand, ResponseBase>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public UpdateUserInformationCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<ResponseBase> Handle(UpdateUserInformationCommand request,
            CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.FindUserByIdIncludeInfoAsync(request.UserId, cancellationToken);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            user.UserInformation.FirstName = request.FirstName ?? user.UserInformation.FirstName;
            user.UserInformation.LastName = request.LastName ?? user.UserInformation.LastName;

            if (user.DisplayName != request.DisplayName)
            {
                var userChats = await _postgresDbContext.UserChats
                    .Include(x => x.Chat)
                    .Where(x => x.UserId == user.Id && x.Chat.ChatType == ChatType.DirectChat)
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

            return ResponseBase.SuccessResponse;
        }
    }
}
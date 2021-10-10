using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

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
                    .Where(x => x.UserId == user.Id &&
                                x.Chat.CommunityType == (int)CommunityType.DirectChat)
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

            user.UserInformation.BirthDay = request.BirthdayDate;

            user.PhoneNumber = request.PhoneNumber;

            user.UserInformation.FirstName = request.FirstName;

            user.UserInformation.LastName = request.LastName;

            user.Email = request.Email;

            user.UserInformation.Website = request.Website;

            user.UserName = request.Username;

            user.Bio = request.Bio;

            user.UserInformation.Address = request.Address;

            user.UserInformation.UpdatedAt = DateTime.UtcNow;

            _postgresDbContext.UserInformation.Update(user.UserInformation);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return ResponseBase.SuccessResponse;
        }
    }
}
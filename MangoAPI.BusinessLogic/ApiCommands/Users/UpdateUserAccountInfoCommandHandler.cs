using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class
    UpdateUserAccountInfoCommandHandler : IRequestHandler<UpdateUserAccountInfoCommand, Result<ResponseBase>>
{
    private readonly MangoDbContext _dbContext;
    private readonly ResponseFactory<ResponseBase> _responseFactory;

    public UpdateUserAccountInfoCommandHandler(MangoDbContext dbContext,
        ResponseFactory<ResponseBase> responseFactory)
    {
        _dbContext = dbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(UpdateUserAccountInfoCommand request,
        CancellationToken cancellationToken)
    {
        var user = await _dbContext.Users
            .Include(x => x.UserInformation)
            .FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);

        if (user is null)
        {
            const string errorMessage = ResponseMessageCodes.UserNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, details);
        }

        if (user.DisplayName != request.DisplayName)
        {
            var userChats = await _dbContext.UserChats
                .Include(x => x.Chat)
                .Where(x => 
                    x.UserId == user.Id && 
                    x.Chat.CommunityType == (int) CommunityType.DirectChat)
                .Select(x => x.Chat)
                .ToListAsync(cancellationToken);

            foreach (var chatEntity in userChats)
            {
                var newTitle = chatEntity.Title.Replace(user.DisplayName, request.DisplayName);
                chatEntity.Title = newTitle;
            }

            user.DisplayName = request.DisplayName;

            _dbContext.Chats.UpdateRange(userChats);
        }

        user.UserInformation.BirthDay = request.BirthdayDate;

        user.UserInformation.Website = request.Website;

        user.UserName = request.Username;

        user.Bio = request.Bio;

        user.UserInformation.Address = request.Address;

        user.UserInformation.UpdatedAt = DateTime.UtcNow;

        _dbContext.UserInformation.Update(user.UserInformation);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
    }
}
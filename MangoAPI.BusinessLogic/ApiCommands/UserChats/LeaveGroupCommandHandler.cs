using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats;

public class LeaveGroupCommandHandler
    : IRequestHandler<LeaveGroupCommand, Result<LeaveGroupResponse>>
{
    private readonly MangoDbContext dbContext;
    private readonly ResponseFactory<LeaveGroupResponse> responseFactory;

    public LeaveGroupCommandHandler(MangoDbContext dbContext,
        ResponseFactory<LeaveGroupResponse> responseFactory)
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
    }

    public async Task<Result<LeaveGroupResponse>> Handle(LeaveGroupCommand request,
        CancellationToken cancellationToken)
    {
        var userChat = await dbContext.UserChats
            .Include(x=>x.Chat)
            .Where(chatEntity => chatEntity.UserId == request.UserId)
            .Where(chatEntity => chatEntity.ChatId == request.ChatId)
            .FirstOrDefaultAsync(cancellationToken);

        if (userChat == null)
        {
            const string errorMessage = ResponseMessageCodes.ChatNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }

        var chat = userChat.Chat;

        if (chat == null)
        {
            const string errorMessage = ResponseMessageCodes.ChatNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }

        if (chat.CommunityType == (int) CommunityType.DirectChat)
        {
            var messages = await dbContext.Messages
                .Where(messageEntity => messageEntity.ChatId == request.ChatId)
                .ToListAsync(cancellationToken);

            dbContext.Messages.RemoveRange(messages);
            dbContext.UserChats.RemoveRange(chat.ChatUsers);
            dbContext.Chats.Remove(chat);

            await dbContext.SaveChangesAsync(cancellationToken);

            return responseFactory.SuccessResponse(LeaveGroupResponse.FromSuccess(chat.Id));
        }

        dbContext.UserChats.Remove(userChat);
        chat.MembersCount--;

        dbContext.Update(chat);
        await dbContext.SaveChangesAsync(cancellationToken);

        return responseFactory.SuccessResponse(LeaveGroupResponse.FromSuccess(chat.Id));
    }
}

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
    private readonly MangoDbContext _dbContext;
    private readonly ResponseFactory<LeaveGroupResponse> _responseFactory;

    public LeaveGroupCommandHandler(MangoDbContext dbContext,
        ResponseFactory<LeaveGroupResponse> responseFactory)
    {
        _dbContext = dbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<LeaveGroupResponse>> Handle(LeaveGroupCommand request,
        CancellationToken cancellationToken)
    {
        var userChat = await _dbContext.UserChats
            .Include(x=>x.Chat)
            .Where(chatEntity => chatEntity.UserId == request.UserId)
            .Where(chatEntity => chatEntity.ChatId == request.ChatId)
            .FirstOrDefaultAsync(cancellationToken);

        if (userChat == null)
        {
            const string errorMessage = ResponseMessageCodes.ChatNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, details);
        }

        var chat = userChat.Chat;
        
        if (chat == null)
        {
            const string errorMessage = ResponseMessageCodes.ChatNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, details);
        }

        if (chat.CommunityType == (int) CommunityType.DirectChat)
        {
            var messages = await _dbContext.Messages
                .Where(messageEntity => messageEntity.ChatId == request.ChatId)
                .ToListAsync(cancellationToken);

            _dbContext.Messages.RemoveRange(messages);
            _dbContext.UserChats.RemoveRange(chat.ChatUsers);
            _dbContext.Chats.Remove(chat);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return _responseFactory.SuccessResponse(LeaveGroupResponse.FromSuccess(chat.Id));
        }

        _dbContext.UserChats.Remove(userChat);
        chat.MembersCount--;

        _dbContext.Update(chat);
        await _dbContext.SaveChangesAsync(cancellationToken);

        return _responseFactory.SuccessResponse(LeaveGroupResponse.FromSuccess(chat.Id));
    }
}
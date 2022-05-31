using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats;

public class LeaveGroupCommandHandler
    : IRequestHandler<LeaveGroupCommand, Result<LeaveGroupResponse>>
{
    private readonly MangoPostgresDbContext _postgresDbContext;
    private readonly ResponseFactory<LeaveGroupResponse> _responseFactory;

    public LeaveGroupCommandHandler(MangoPostgresDbContext postgresDbContext,
        ResponseFactory<LeaveGroupResponse> responseFactory)
    {
        _postgresDbContext = postgresDbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<LeaveGroupResponse>> Handle(LeaveGroupCommand request,
        CancellationToken cancellationToken)
    {
        var userChat = await _postgresDbContext.UserChats
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
            var messages = await _postgresDbContext.Messages
                .Where(messageEntity => messageEntity.ChatId == request.ChatId)
                .ToListAsync(cancellationToken);

            _postgresDbContext.Messages.RemoveRange(messages);
            _postgresDbContext.UserChats.RemoveRange(chat.ChatUsers);
            _postgresDbContext.Chats.Remove(chat);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return _responseFactory.SuccessResponse(LeaveGroupResponse.FromSuccess(chat.Id));
        }

        _postgresDbContext.UserChats.Remove(userChat);
        chat.MembersCount--;

        _postgresDbContext.Update(chat);
        await _postgresDbContext.SaveChangesAsync(cancellationToken);

        return _responseFactory.SuccessResponse(LeaveGroupResponse.FromSuccess(chat.Id));
    }
}
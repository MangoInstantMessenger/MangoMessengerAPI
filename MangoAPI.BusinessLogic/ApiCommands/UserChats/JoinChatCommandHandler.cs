using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats;

public class JoinChatCommandHandler : IRequestHandler<JoinChatCommand, Result<ResponseBase>>
{
    private readonly MangoDbContext _dbContext;
    private readonly ResponseFactory<ResponseBase> _responseFactory;

    public JoinChatCommandHandler(MangoDbContext dbContext,
        ResponseFactory<ResponseBase> responseFactory)
    {
        _dbContext = dbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(JoinChatCommand request,
        CancellationToken cancellationToken)
    {
        var alreadyJoined = await
            _dbContext.UserChats.AnyAsync(userChatEntity => 
                userChatEntity.UserId == request.UserId && 
                userChatEntity.ChatId == request.ChatId, cancellationToken);

        if (alreadyJoined)
        {
            const string errorMessage = ResponseMessageCodes.UserAlreadyJoinedGroup;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, details);
        }

        var chat = await _dbContext.Chats
            .Where(chatEntity => chatEntity.CommunityType != (int) CommunityType.DirectChat)
            .FirstOrDefaultAsync(chatEntity => chatEntity.Id == request.ChatId, cancellationToken);

        if (chat == null)
        {
            const string errorMessage = ResponseMessageCodes.ChatNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, details);
        }

        _dbContext.UserChats.Add(
            new UserChatEntity
            {
                ChatId = request.ChatId,
                UserId = request.UserId,
                RoleId = (int) UserRole.User,
            });

        chat.MembersCount += 1;

        _dbContext.Update(chat);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
    }
}
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities.ChatEntities;
using MangoAPI.Domain.Enums;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public class JoinChatCommandHandler : IRequestHandler<JoinChatCommand, Result<ResponseBase>>
{
    private readonly MangoDbContext dbContext;
    private readonly ResponseFactory<ResponseBase> responseFactory;

    public JoinChatCommandHandler(
        MangoDbContext dbContext,
        ResponseFactory<ResponseBase> responseFactory)
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(
        JoinChatCommand request,
        CancellationToken cancellationToken)
    {
        var alreadyJoined = await
            dbContext.UserChats.AnyAsync(
                userChatEntity => userChatEntity.UserId == request.UserId &&
                                  userChatEntity.ChatId == request.ChatId,
                cancellationToken);

        if (alreadyJoined)
        {
            const string errorMessage = ResponseMessageCodes.UserAlreadyJoinedGroup;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }

        var chat = await dbContext.Chats
            .Where(chatEntity => chatEntity.CommunityType != CommunityType.DirectChat)
            .FirstOrDefaultAsync(chatEntity => chatEntity.Id == request.ChatId, cancellationToken);

        if (chat == null)
        {
            const string errorMessage = ResponseMessageCodes.ChatNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }
        
        var userChat = UserChatEntity.Create(request.UserId, request.ChatId, UserRole.User);

        dbContext.UserChats.Add(userChat);

        chat.IncrementMembersCount(1);

        dbContext.Update(chat);

        await dbContext.SaveChangesAsync(cancellationToken);

        return responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
    }
}

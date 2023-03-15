using MangoAPI.BusinessLogic.HubConfig;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public class LeaveGroupCommandHandler
    : IRequestHandler<LeaveGroupCommand, Result<LeaveGroupResponse>>
{
    private readonly MangoDbContext dbContext;
    private readonly ResponseFactory<LeaveGroupResponse> responseFactory;
    private readonly IHubContext<ChatHub, IHubClient> hubContext;

    public LeaveGroupCommandHandler(
        MangoDbContext dbContext,
        ResponseFactory<LeaveGroupResponse> responseFactory,
        IHubContext<ChatHub, IHubClient> hubContext)
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
        this.hubContext = hubContext;
    }

    public async Task<Result<LeaveGroupResponse>> Handle(
        LeaveGroupCommand request,
        CancellationToken cancellationToken)
    {
        var chat = await dbContext.Chats
            .Include(x => x.ChatUsers)
            .FirstOrDefaultAsync(x => x.Id == request.ChatId, cancellationToken);

        if (chat == null)
        {
            const string errorMessage = ResponseMessageCodes.ChatNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }

        var userBelongsToChat = chat.ChatUsers.Any(x => x.UserId == request.UserId);

        if (!userBelongsToChat)
        {
            const string errorMessage = ResponseMessageCodes.Unauthorized;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }

        if (chat.CommunityType == CommunityType.DirectChat)
        {
            var messages = await dbContext.Messages
                .Where(messageEntity => messageEntity.ChatId == request.ChatId)
                .ToListAsync(cancellationToken);

            var partnerId = chat.ChatUsers.First(x => x.UserId != request.UserId).UserId;

            dbContext.Messages.RemoveRange(messages);
            dbContext.UserChats.RemoveRange(chat.ChatUsers);
            dbContext.Chats.Remove(chat);

            await dbContext.SaveChangesAsync(cancellationToken);

            await hubContext.Clients.Group(partnerId.ToString()).PrivateChatDeletedAsync(request.ChatId);

            return responseFactory.SuccessResponse(LeaveGroupResponse.FromSuccess(chat.Id));
        }
        
        var userChat = chat.ChatUsers.First(x => x.UserId == request.UserId);
        chat.IncrementMembersCount(-1);

        dbContext.Update(chat);
        dbContext.UserChats.Remove(userChat);
        
        await dbContext.SaveChangesAsync(cancellationToken);

        return responseFactory.SuccessResponse(LeaveGroupResponse.FromSuccess(chat.Id));
    }
}
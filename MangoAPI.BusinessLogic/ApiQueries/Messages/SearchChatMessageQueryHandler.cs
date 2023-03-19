using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages;

public class SearchChatMessageQueryHandler
    : IRequestHandler<SearchChatMessagesQuery, Result<SearchChatMessagesResponse>>
{
    private readonly MangoDbContext dbContext;
    private readonly ResponseFactory<SearchChatMessagesResponse> responseFactory;
    private readonly IBlobServiceSettings blobServiceSettings;

    public SearchChatMessageQueryHandler(
        MangoDbContext dbContext,
        ResponseFactory<SearchChatMessagesResponse> responseFactory,
        IBlobServiceSettings blobServiceSettings)
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
        this.blobServiceSettings = blobServiceSettings;
    }

    public async Task<Result<SearchChatMessagesResponse>> Handle(
        SearchChatMessagesQuery request,
        CancellationToken cancellationToken)
    {
        var userChat = await dbContext.UserChats
            .Where(chatEntity => chatEntity.UserId == request.UserId)
            .Where(chatEntity => chatEntity.ChatId == request.ChatId)
            .FirstOrDefaultAsync(cancellationToken);

        if (userChat is null)
        {
            const string errorMessage = ResponseMessageCodes.PermissionDenied;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, details);
        }

        var query = dbContext.Messages.AsNoTracking()
            .Where(x => x.ChatId == request.ChatId)
            .Where(x => EF.Functions.Like(x.Text, $"%{request.MessageText}%"))
            .OrderBy(x => x.CreatedAt)
            .Select(x => new Message
            {
                MessageId = x.Id,
                ChatId = x.ChatId,
                UserId = x.UserId,
                DisplayName = x.User.DisplayName,
                DisplayNameColour = x.User.DisplayNameColour,
                Text = x.Text,
                CreatedAt = x.CreatedAt,
                UpdatedAt = x.UpdatedAt,
                Self = x.User.Id == request.UserId,
                InReplyToUser = x.InReplyToUser,
                InReplyToText = x.InReplyToText,

                AuthorImageUrl = x.User.ImageFileName != null
                    ? $"{blobServiceSettings.MangoBlobAccess}/{x.User.ImageFileName}"
                    : null,

                AttachmentUrl = x.AttachmentFileName != null
                    ? $"{blobServiceSettings.MangoBlobAccess}/{x.AttachmentFileName}"
                    : null,
            }).Take(200);

        var result = await query.ToListAsync(cancellationToken);

        return responseFactory.SuccessResponse(SearchChatMessagesResponse.FromSuccess(result));
    }
}

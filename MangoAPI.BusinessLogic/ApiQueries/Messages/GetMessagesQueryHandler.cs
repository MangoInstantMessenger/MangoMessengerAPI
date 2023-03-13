using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages;

public class GetMessagesQueryHandler : IRequestHandler<GetMessagesQuery, Result<GetMessagesResponse>>
{
    private readonly MangoDbContext dbContext;
    private readonly ResponseFactory<GetMessagesResponse> responseFactory;
    private readonly IBlobServiceSettings blobServiceSettings;

    public GetMessagesQueryHandler(
        MangoDbContext dbContext,
        ResponseFactory<GetMessagesResponse> responseFactory,
        IBlobServiceSettings blobServiceSettings)
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
        this.blobServiceSettings = blobServiceSettings;
    }

    public async Task<Result<GetMessagesResponse>> Handle(GetMessagesQuery request, CancellationToken cancellationToken)
    {
        var messages = await dbContext
            .Messages
            .AsNoTracking()
            .Where(x => x.ChatId == request.ChatId)
            .OrderBy(x => x.CreatedAt)
            .Select(messageEntity => new Message
            {
                MessageId = messageEntity.Id,
                ChatId = messageEntity.ChatId,
                UserId = messageEntity.UserId,
                MessageText = messageEntity.Text,
                UpdatedAt = messageEntity.UpdatedAt,
                CreatedAt = messageEntity.CreatedAt,
                UserDisplayName = messageEntity.User.DisplayName,
                UserDisplayNameColour = messageEntity.User.DisplayNameColour,
                Self = messageEntity.User.Id == request.UserId,
                InReplyToUser = messageEntity.InReplyToUser,
                InReplyToText = messageEntity.InReplyToText,

                MessageAuthorPictureUrl = messageEntity.User.ImageFileName != null
                    ? $"{blobServiceSettings.MangoBlobAccess}/{messageEntity.User.ImageFileName}"
                    : null,

                MessageAttachmentUrl = messageEntity.AttachmentFileName != null
                    ? $"{blobServiceSettings.MangoBlobAccess}/{messageEntity.AttachmentFileName}"
                    : null,
            }).Take(200).ToListAsync(cancellationToken);

        return responseFactory.SuccessResponse(GetMessagesResponse.FromSuccess(messages));
    }
}

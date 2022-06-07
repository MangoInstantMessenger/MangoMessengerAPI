using MangoAPI.BusinessLogic.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Infrastructure.Database;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages;

public class GetMessagesQueryHandler : IRequestHandler<GetMessagesQuery, Result<GetMessagesResponse>>
{
    private readonly MangoDbContext _dbContext;
    private readonly ResponseFactory<GetMessagesResponse> _responseFactory;
    private readonly IBlobServiceSettings _blobServiceSettings;

    public GetMessagesQueryHandler(MangoDbContext dbContext,
        ResponseFactory<GetMessagesResponse> responseFactory,
        IBlobServiceSettings blobServiceSettings)
    {
        _dbContext = dbContext;
        _responseFactory = responseFactory;
        _blobServiceSettings = blobServiceSettings;
    }

    public async Task<Result<GetMessagesResponse>> Handle(GetMessagesQuery request, CancellationToken cancellationToken)
    {
        var messages = await _dbContext
            .Messages
            .AsNoTracking()
            .Where(x => x.ChatId == request.ChatId)
            .OrderBy(x => x.CreatedAt)
            .Select(messageEntity => new Message
            {
                MessageId = messageEntity.Id,
                ChatId = messageEntity.ChatId,
                UserId = messageEntity.UserId,
                MessageText = messageEntity.Content,
                UpdatedAt = messageEntity.UpdatedAt,
                CreatedAt = messageEntity.CreatedAt,
                UserDisplayName = messageEntity.User.DisplayName,
                Self = messageEntity.User.Id == request.UserId,
                InReplayToAuthor = messageEntity.InReplayToAuthor,
                InReplayToText = messageEntity.InReplayToText,

                MessageAuthorPictureUrl = messageEntity.User.Image != null
                    ? $"{_blobServiceSettings.MangoBlobAccess}/{messageEntity.User.Image}"
                    : null,

                MessageAttachmentUrl = messageEntity.Attachment != null
                    ? $"{_blobServiceSettings.MangoBlobAccess}/{messageEntity.Attachment}"
                    : null,
            }).Take(200).ToListAsync(cancellationToken);

        return _responseFactory.SuccessResponse(GetMessagesResponse.FromSuccess(messages));
    }
}
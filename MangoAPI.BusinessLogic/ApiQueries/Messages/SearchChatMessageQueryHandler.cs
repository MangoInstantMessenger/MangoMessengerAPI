using MangoAPI.BusinessLogic.Models;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages;

public class SearchChatMessageQueryHandler
    : IRequestHandler<SearchChatMessagesQuery, Result<SearchChatMessagesResponse>>
{
    private readonly MangoPostgresDbContext _postgresDbContext;
    private readonly ResponseFactory<SearchChatMessagesResponse> _responseFactory;
    private readonly IBlobServiceSettings _blobServiceSettings;

    public SearchChatMessageQueryHandler(
        MangoPostgresDbContext postgresDbContext,
        ResponseFactory<SearchChatMessagesResponse> responseFactory,
        IBlobServiceSettings blobServiceSettings)
    {
        _postgresDbContext = postgresDbContext;
        _responseFactory = responseFactory;
        _blobServiceSettings = blobServiceSettings;
    }

    public async Task<Result<SearchChatMessagesResponse>> Handle(SearchChatMessagesQuery request,
        CancellationToken cancellationToken)
    {
        var userChat = await _postgresDbContext.UserChats
            .Where(chatEntity => chatEntity.UserId == request.UserId)
            .Where(chatEntity => chatEntity.ChatId == request.ChatId)
            .FirstOrDefaultAsync(cancellationToken);

        if (userChat is null)
        {
            const string errorMessage = ResponseMessageCodes.PermissionDenied;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, details);
        }

        IQueryable<Message> query;

        var isRelational = _postgresDbContext.Database.IsRelational();

        if (isRelational)
        {
            query = _postgresDbContext.Messages.AsNoTracking()
                .Where(x => x.ChatId == request.ChatId)
                .Where(x => EF.Functions.ILike(x.Content, $"%{request.MessageText}%"))
                .OrderBy(x => x.CreatedAt)
                .Select(x => new Message
                {
                    MessageId = x.Id,
                    ChatId = x.ChatId,
                    UserId = x.UserId,
                    UserDisplayName = x.User.DisplayName,
                    MessageText = x.Content,
                    CreatedAt = x.CreatedAt,
                    UpdatedAt = x.UpdatedAt,
                    Self = x.User.Id == request.UserId,
                    InReplayToAuthor = x.InReplayToAuthor,
                    InReplayToText = x.InReplayToText,

                    MessageAuthorPictureUrl = x.User.Image != null
                        ? $"{_blobServiceSettings.MangoBlobAccess}/{x.User.Image}"
                        : null,

                    MessageAttachmentUrl = x.Attachment != null
                        ? $"{_blobServiceSettings.MangoBlobAccess}/{x.Attachment}"
                        : null,
                }).Take(200);
        }
        else
        {
            query = _postgresDbContext.Messages.AsNoTracking()
                .Where(x => x.ChatId == request.ChatId)
                .Where(x => x.Content.Contains(request.MessageText))
                .OrderBy(x => x.CreatedAt)
                .Select(x => new Message
                {
                    MessageId = x.Id,
                    ChatId = x.ChatId,
                    UserId = x.UserId,
                    UserDisplayName = x.User.DisplayName,
                    MessageText = x.Content,
                    CreatedAt = x.CreatedAt,
                    UpdatedAt = x.UpdatedAt,
                    Self = x.User.Id == request.UserId,
                    InReplayToAuthor = x.InReplayToAuthor,
                    InReplayToText = x.InReplayToText,

                    MessageAuthorPictureUrl = x.User.Image != null
                        ? $"{_blobServiceSettings.MangoBlobAccess}/{x.User.Image}"
                        : null,

                    MessageAttachmentUrl = x.Attachment != null
                        ? $"{_blobServiceSettings.MangoBlobAccess}/{x.Attachment}"
                        : null,
                }).Take(200);
        }
            
            

        var result = await query.ToListAsync(cancellationToken);

        return _responseFactory.SuccessResponse(SearchChatMessagesResponse.FromSuccess(result));
    }
}
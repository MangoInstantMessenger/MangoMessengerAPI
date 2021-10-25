using MangoAPI.BusinessLogic.Models;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages
{
    public class SearchChatMessageQueryHandler 
        : IRequestHandler<SearchChatMessagesQuery, Result<SearchChatMessagesResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public SearchChatMessageQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<Result<SearchChatMessagesResponse>> Handle(SearchChatMessagesQuery request, CancellationToken cancellationToken)
        {
            var userChat = await _postgresDbContext.UserChats.FindUserChatByIdAsync(request.UserId, request.ChatId, cancellationToken);

            if (userChat is null)
            {
                return new Result<SearchChatMessagesResponse>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.PermissionDenied,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.PermissionDenied],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            var query = _postgresDbContext.Messages.AsNoTracking()
                .Include(x => x.User)
                .Where(x => x.ChatId == request.ChatId)
                .OrderBy(x => x.CreatedAt)
                .Select(x => new Message
                {
                    MessageId = x.Id,
                    ChatId = x.ChatId,
                    UserId = x.UserId,
                    UserDisplayName = x.User.DisplayName,
                    MessageText = x.Content,
                    CreatedAt = x.CreatedAt.ToShortTimeString(),
                    UpdatedAt = x.UpdatedAt.HasValue ? x.UpdatedAt.Value.ToShortTimeString() : null,
                    Self = x.User.Id == request.UserId,
                    IsEncrypted = x.IsEncrypted,
                    AuthorPublicKey = x.AuthorPublicKey,
                    InReplayToAuthor = x.InReplayToAuthor,
                    InReplayToText = x.InReplayToText,

                    MessageAuthorPictureUrl = x.User.Image != null
                        ? $"{EnvironmentConstants.BackendAddress}Uploads/{x.User.Image}"
                        : null,

                    MessageAttachmentUrl = x.Attachment != null
                        ? $"{EnvironmentConstants.BackendAddress}Uploads/{x.Attachment}"
                        : null,
                }).Take(200);

            if (!string.IsNullOrEmpty(request.MessageText) || !string.IsNullOrWhiteSpace(request.MessageText))
            {
                query = query.Where(x => x.MessageText.Contains(request.MessageText));
            }

            var result = await query.ToListAsync(cancellationToken);

            return new Result<SearchChatMessagesResponse>
            {
                Error = null,
                Response = SearchChatMessagesResponse.FromSuccess(result),
                StatusCode = 200
            };
        }
    }
}
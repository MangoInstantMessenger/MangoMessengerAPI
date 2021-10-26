using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages
{
    public class SearchChatMessageQueryHandler : IRequestHandler<SearchChatMessagesQuery, SearchChatMessagesResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public SearchChatMessageQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<SearchChatMessagesResponse> Handle(SearchChatMessagesQuery request, CancellationToken cancellationToken)
        {
            var userChat = await _postgresDbContext.UserChats.FindUserChatByIdAsync(request.UserId, request.ChatId, cancellationToken);

            if (userChat is null)
            {
                throw new BusinessException(ResponseMessageCodes.PermissionDenied);
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

            return SearchChatMessagesResponse.FromSuccess(result);
        }
    }
}
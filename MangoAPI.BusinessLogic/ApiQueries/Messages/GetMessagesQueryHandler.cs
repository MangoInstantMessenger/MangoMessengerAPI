using MangoAPI.BusinessLogic.Models;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages;

public class GetMessagesQueryHandler : IRequestHandler<GetMessagesQuery, Result<GetMessagesResponse>>
{
    private readonly MangoPostgresDbContext _postgresDbContext;
    private readonly ResponseFactory<GetMessagesResponse> _responseFactory;

    public GetMessagesQueryHandler(MangoPostgresDbContext postgresDbContext,
        ResponseFactory<GetMessagesResponse> responseFactory)
    {
        _postgresDbContext = postgresDbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<GetMessagesResponse>> Handle(GetMessagesQuery request, CancellationToken cancellationToken)
    {
        var messages = await _postgresDbContext
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
                UpdatedAt = messageEntity.UpdatedAt.HasValue ? messageEntity.UpdatedAt.Value.ToShortTimeString() : null,
                CreatedAt = messageEntity.CreatedAt.ToShortTimeString(),
                UserDisplayName = messageEntity.User.DisplayName,
                Self = messageEntity.User.Id == request.UserId,
                InReplayToAuthor = messageEntity.InReplayToAuthor,
                InReplayToText = messageEntity.InReplayToText,

                MessageAuthorPictureUrl = messageEntity.User.Image != null
                    ? $"{EnvironmentConstants.MangoBlobAccess}/{messageEntity.User.Image}"
                    : null,

                MessageAttachmentUrl = messageEntity.Attachment != null
                    ? $"{EnvironmentConstants.MangoBlobAccess}/{messageEntity.Attachment}"
                    : null,
            }).Take(200).ToListAsync(cancellationToken);

        return _responseFactory.SuccessResponse(GetMessagesResponse.FromSuccess(messages));
    }
}
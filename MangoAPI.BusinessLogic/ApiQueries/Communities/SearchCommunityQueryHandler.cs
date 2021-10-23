using MangoAPI.BusinessLogic.Models;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Enums;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities
{
    public class SearchCommunityQueryHandler 
        : IRequestHandler<SearchCommunityQuery, GenericResponse<SearchCommunityResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public SearchCommunityQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GenericResponse<SearchCommunityResponse>> Handle(SearchCommunityQuery request,
            CancellationToken cancellationToken)
        {
            var query = _postgresDbContext.Chats
                .AsNoTracking()
                .Where(x => x.CommunityType == (int)CommunityType.PublicChannel
                            || x.CommunityType == (int)CommunityType.ReadOnlyChannel)
                .Where(x => request.DisplayName == null
                            || EF.Functions.ILike(x.Title, $"%{request.DisplayName}%"))
                .Include(x => x.Messages)
                .ThenInclude(x => x.User)
                .Select(x => new Chat
                {
                    ChatId = x.Id,
                    Title = x.Title,
                    CommunityType = (CommunityType)x.CommunityType,
                    ChatLogoImageUrl = x.Image != null
                        ? $"{EnvironmentConstants.BackendAddress}Uploads/{x.Image}"
                        : null,
                    Description = x.Description,
                    MembersCount = x.MembersCount,
                    IsArchived = false,
                    IsMember = false,
                    UpdatedAt = x.UpdatedAt,
                    LastMessage = x.Messages.Any()
                        ? x.Messages.OrderBy(messageEntity => messageEntity.CreatedAt).Select(messageEntity =>
                            new Message
                            {
                                MessageId = messageEntity.Id,
                                ChatId = messageEntity.ChatId,
                                UserDisplayName = messageEntity.User.DisplayName,
                                MessageText = messageEntity.Content,
                                CreatedAt = messageEntity.CreatedAt.ToShortTimeString(),
                                UpdatedAt = messageEntity.UpdatedAt.HasValue
                                    ? messageEntity.UpdatedAt.Value.ToShortTimeString()
                                    : null,
                                IsEncrypted = messageEntity.IsEncrypted,
                                AuthorPublicKey = messageEntity.AuthorPublicKey,
                                MessageAuthorPictureUrl = messageEntity.User.Image != null
                                    ? $"{EnvironmentConstants.BackendAddress}Uploads/{messageEntity.User.Image}"
                                    : null,
                                Self = messageEntity.UserId == request.UserId,
                            }).Last()
                        : null,
                }).Distinct();

            var chats = await query.Take(200).ToListAsync(cancellationToken);

            var joinedChatIds = await _postgresDbContext.UserChats.AsNoTracking()
                .Where(x => x.UserId == request.UserId)
                .Select(x => x.ChatId)
                .ToListAsync(cancellationToken);

            chats = chats.Where(x => !joinedChatIds.Contains(x.ChatId)).ToList();

            return new GenericResponse<SearchCommunityResponse>
            {
                Error = null,
                Response = SearchCommunityResponse.FromSuccess(chats),
                StatusCode = 200
            };
        }
    }
}
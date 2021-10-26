using MangoAPI.BusinessLogic.Models;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Enums;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Constants;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities
{
    public class SearchCommunityQueryHandler : IRequestHandler<SearchCommunityQuery, SearchCommunityResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public SearchCommunityQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<SearchCommunityResponse> Handle(SearchCommunityQuery request,
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
                    LastMessageAuthor = x.LastMessageAuthor,
                    LastMessageText = x.LastMessageText,
                    LastMessageTime = x.LastMessageTime,
                }).Distinct();

            var chats = await query.Take(200).ToListAsync(cancellationToken);

            //var joinedChatIds = await _postgresDbContext.UserChats.AsNoTracking()
            //    .Where(x => x.UserId == request.UserId)
            //    .Select(x => x.ChatId)
            //    .ToListAsync(cancellationToken);

            //chats = chats.Where(x => !joinedChatIds.Contains(x.ChatId)).ToList();

            return SearchCommunityResponse.FromSuccess(chats);
        }
    }
}
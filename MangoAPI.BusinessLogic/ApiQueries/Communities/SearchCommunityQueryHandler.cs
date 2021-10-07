using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Enums;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

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
            // TODO: optimize this query

            var chats = await _postgresDbContext
                .Chats
                .GetChannelsIncludeMessagesAsync(cancellationToken);

            var userChats =
                await _postgresDbContext.UserChats
                    .FindUserChatsByIdIncludeMessagesAsync(request.UserId, cancellationToken);

            if (!string.IsNullOrEmpty(request.DisplayName) || !string.IsNullOrWhiteSpace(request.DisplayName))
            {
                chats = chats
                    .Where(x => x.Title.ToUpper().Contains(request.DisplayName.ToUpper()))
                    .ToList();
            }

            var resultList = new List<Chat>();

            foreach (var chat in chats)
            {
                var isMember = userChats.Any(x => x.Chat.Id == chat.Id);
                
                var currentChat = new Chat
                {
                    ChatId = chat.Id,
                    Title = chat.Title,
                    ChatLogoImageUrl = StringService.GetDocumentUrl(chat.Image),
                    Description = chat.Description,
                    MembersCount = chat.MembersCount,
                    CommunityType = (CommunityType) chat.CommunityType,
                    IsMember = isMember,
                    LastMessage = chat.Messages.Any()
                        ? chat.Messages.OrderBy(x => x.CreatedAt).Select(x =>
                            new Message
                            {
                                MessageId = x.Id,
                                UserDisplayName = x.User.DisplayName,
                                MessageText = x.Content,
                                CreatedAt = x.CreatedAt.ToShortTimeString(),
                                UpdatedAt = x.UpdatedAt?.ToShortTimeString(),
                                IsEncrypted = x.IsEncrypted,
                                AuthorPublicKey = x.AuthorPublicKey,
                                MessageAuthorPictureUrl = StringService.GetDocumentUrl(x.User.Image),
                            }).Last()
                        : null,
                };

                resultList.Add(currentChat);
            }

            return SearchCommunityResponse.FromSuccess(resultList);
        }
    }
}
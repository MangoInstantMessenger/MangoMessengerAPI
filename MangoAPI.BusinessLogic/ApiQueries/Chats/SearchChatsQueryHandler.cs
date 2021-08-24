namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
    using DataAccess.Database;
    using MangoAPI.BusinessLogic.Models;
    using MangoAPI.Domain.Enums;
    using MediatR;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    public class SearchChatsQueryHandler : IRequestHandler<SearchChatsQuery, SearchChatsResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public SearchChatsQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<SearchChatsResponse> Handle(SearchChatsQuery request, CancellationToken cancellationToken)
        {
            var chats = await _postgresDbContext
                .Chats
                .AsNoTracking()
                .Include(x => x.Messages)
                .ThenInclude(x => x.User)
                .Where(x => x.Title.ToLower().Contains(request.DisplayName.ToLower()))
                .Where(x => x.ChatType != ChatType.PrivateChannel)
                .Where(x => x.ChatType != ChatType.DirectChat)
                .ToListAsync(cancellationToken);

            var resultList = new List<Chat>();

            foreach (var chat in chats)
            {
                var isMember = await _postgresDbContext.UserChats
                    .AnyAsync(x => x.ChatId == chat.Id && x.UserId == request.UserId, cancellationToken);

                resultList.Add(new Chat
                {
                    ChatId = chat.Id,
                    Title = chat.Title,
                    Image = chat.Image,
                    LastMessage = chat.Messages.Any()
                            ? chat.Messages.Last().Content
                            : null,
                    LastMessageAuthor = chat.Messages.Any()
                            ? chat.Messages.Last().User.DisplayName
                            : null,
                    LastMessageAt = chat.Messages.Any()
                            ? chat.Messages.Last().Created.ToShortTimeString()
                            : null,
                    MembersCount = chat.MembersCount,
                    ChatType = chat.ChatType,
                    IsMember = isMember,
                });
            }

            return SearchChatsResponse.FromSuccess(resultList);
        }
    }
}
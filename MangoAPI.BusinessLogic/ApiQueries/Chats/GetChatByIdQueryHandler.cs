using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
    public class GetChatByIdQueryHandler : IRequestHandler<GetChatByIdQuery, GetChatByIdResponse>
    {
        private readonly MangoPostgresDbContext postgresDbContext;

        public GetChatByIdQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            this.postgresDbContext = postgresDbContext;
        }

        public async Task<GetChatByIdResponse> Handle(GetChatByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await postgresDbContext.Users
                .FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var chatEntity = await postgresDbContext.Chats
                .Include(x => x.Messages)
                .ThenInclude(x => x.User)
                .FirstOrDefaultAsync(x => x.Id == request.ChatId, cancellationToken);

            if (chatEntity is null)
            {
                throw new BusinessException(ResponseMessageCodes.ChatNotFound);
            }

            var userChat = await postgresDbContext.UserChats
                .Where(x => x.UserId == request.UserId)
                .FirstOrDefaultAsync(x => x.ChatId == request.ChatId, cancellationToken);

            switch (userChat)
            {
                case null when chatEntity.ChatType == ChatType.DirectChat:
                    throw new BusinessException(ResponseMessageCodes.ChatNotFound);

                case null when chatEntity.ChatType == ChatType.PrivateChannel:
                    throw new BusinessException(ResponseMessageCodes.ChatNotFound);
            }

            var chat = new Chat()
            {
                ChatId = chatEntity.Id,
                Title = chatEntity.Title,
                ChatType = chatEntity.ChatType,
                Image = chatEntity.Image,
                LastMessageAuthor = chatEntity.Messages.Any()
                    ? chatEntity.Messages.OrderBy(messageEntity => messageEntity.Created).Last().User.DisplayName
                    : null,
                LastMessage = chatEntity.Messages.Any()
                    ? chatEntity.Messages.OrderBy(messageEntity => messageEntity.Created).Last().Content
                    : null,
                LastMessageAt = chatEntity.Messages.Any()
                    ? chatEntity.Messages.OrderBy(messageEntity => messageEntity.Created).Last().Created.ToShortTimeString()
                    : null,
                MembersCount = chatEntity.MembersCount,
                IsMember = userChat != null,
            };

            return GetChatByIdResponse.FromSuccess(chat);
        }
    }
}
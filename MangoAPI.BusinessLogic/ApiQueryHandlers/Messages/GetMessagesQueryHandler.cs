using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.Messages;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.Responses.Messages;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiQueryHandlers.Messages
{
    public class GetMessagesQueryHandler : IRequestHandler<GetMessagesQuery, GetMessagesResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly UserManager<UserEntity> _userManager;

        public GetMessagesQueryHandler(MangoPostgresDbContext postgresDbContext, UserManager<UserEntity> userManager)
        {
            _postgresDbContext = postgresDbContext;
            _userManager = userManager;
        }

        public async Task<GetMessagesResponse> Handle(GetMessagesQuery request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId);            
            
            if (user == null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }           
            
            var belongsToChat = await _postgresDbContext.UserChats
                .AsNoTracking()
                .Where(userChatEntity => userChatEntity.UserId == user.Id)
                .AnyAsync(userChatEntity => userChatEntity.ChatId == request.ChatId, cancellationToken);            
            
            if (!belongsToChat)
            {
                throw new BusinessException(ResponseMessageCodes.PermissionDenied);
            }           
            
            var chat = _postgresDbContext.Messages.AsNoTracking()
                .Include(x => x.User)
                .Where(x => x.ChatId == request.ChatId)
                .AsEnumerable();            
            
            return GetMessagesResponse.FromSuccess(chat, user);
        }
    }
}
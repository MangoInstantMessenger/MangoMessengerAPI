using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.ApiQueries.Chats;
using MangoAPI.DTO.Responses.Chats;
using MangoAPI.Infrastructure.BusinessExceptions;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.QueryHandlers.Chats
{
    public class GetChatsQueryHandler : IRequestHandler<GetChatsQuery, GetChatsResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly UserManager<UserEntity> _userManager;

        public GetChatsQueryHandler(MangoPostgresDbContext postgresDbContext, UserManager<UserEntity> userManager)
        {
            _postgresDbContext = postgresDbContext;
            _userManager = userManager;
        }

        public async Task<GetChatsResponse> Handle(GetChatsQuery request, CancellationToken cancellationToken)
        {
            var currentUser = await _userManager.FindByIdAsync(request.UserId);

            if (currentUser == null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var chats = await _postgresDbContext.UserChats
                .Include(x => x.Chat)
                .ThenInclude(x => x.Messages)
                .ThenInclude(x => x.User)
                .Where(x => x.UserId == currentUser.Id)
                .ToListAsync(cancellationToken);

            return GetChatsResponse.FromSuccess(chats);
        }
    }
}
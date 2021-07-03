using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MangoAPI.DTO.Commands.Chats;
using MangoAPI.DTO.Responses.Chats;
using MangoAPI.Infrastructure.Database;
using MediatR;

namespace MangoAPI.Infrastructure.CommandHandlers.Chats
{
    public class CreateGroupCommandHandler : IRequestHandler<CreateGroupCommand, CreateChatEntityResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IUserService _userService;
        private readonly ICookieService _cookieService;

        public CreateGroupCommandHandler(MangoPostgresDbContext postgresDbContext, IUserService userService,
            ICookieService cookieService)
        {
            _postgresDbContext = postgresDbContext;
            _userService = userService;
            _cookieService = cookieService;
        }

        public async Task<CreateChatEntityResponse> Handle(CreateGroupCommand request,
            CancellationToken cancellationToken)
        {
            if (request.GroupTitle == null)
            {
                return CreateChatEntityResponse.InvalidOrEmptyChatTitle;
            }

            if (request.GroupType is ChatType.DirectChat)
            {
                return CreateChatEntityResponse.InvalidGroupType;
            }

            var refreshTokenId = _cookieService.Get(CookieConstants.MangoRefreshTokenId);

            var currentUser = await _userService.GetUserByTokenIdAsync(refreshTokenId);

            var directChatEntity = new ChatEntity
            {
                ChatType = request.GroupType,
                Title = request.GroupTitle
            };

            await _postgresDbContext.Chats.AddAsync(directChatEntity, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            _postgresDbContext.UserChats.Add(new UserChatEntity
            {
                ChatId = directChatEntity.Id, RoleId = UserRole.Owner, UserId = currentUser.Id
            });

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return CreateChatEntityResponse.DirectChatCreateSuccess;
        }
    }
}
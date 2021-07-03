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
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.CommandHandlers.Chats
{
    public class CreateDirectChatCommandHandler : IRequestHandler<CreateDirectChatCommand, CreateChatEntityResponse>
    {
        private readonly ICookieService _cookieService;
        private readonly IJwtRefreshService _jwtRefreshService;
        private readonly IRequestMetadataService _metadataService;
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IUserService _userService;

        public CreateDirectChatCommandHandler(ICookieService cookieService, IJwtRefreshService jwtRefreshService,
            IRequestMetadataService metadataService, MangoPostgresDbContext postgresDbContext, IUserService userService)
        {
            _cookieService = cookieService;
            _jwtRefreshService = jwtRefreshService;
            _metadataService = metadataService;
            _postgresDbContext = postgresDbContext;
            _userService = userService;
        }

        public async Task<CreateChatEntityResponse> Handle(CreateDirectChatCommand request,
            CancellationToken cancellationToken)
        {
            var partner = await _userService.GetUserByIdAsync(request.PartnerId);

            if (partner == null)
            {
                return CreateChatEntityResponse.UserNotFound;
            }

            var refreshTokenId = _cookieService.Get(CookieConstants.MangoRefreshTokenId);

            var currentUser = await _userService.GetUserByTokenIdAsync(refreshTokenId);

            var directChatEntity = new ChatEntity
            {
                ChatType = ChatType.DirectChat,
                Title = $"{currentUser.DisplayName} / {partner.DisplayName}"
            };
            
            // TODO: verify that chat already exists

            await _postgresDbContext.Chats.AddAsync(directChatEntity, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            var userChats = new[]
            {
                new UserChatEntity {ChatId = directChatEntity.Id, RoleId = UserRole.User, UserId = currentUser.Id},
                new UserChatEntity {ChatId = directChatEntity.Id, RoleId = UserRole.User, UserId = request.PartnerId}
            };

            _postgresDbContext.UserChats.AddRange(userChats);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return CreateChatEntityResponse.SuccessResponse;
        }
    }
}
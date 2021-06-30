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

        public CreateDirectChatCommandHandler(ICookieService cookieService, IJwtRefreshService jwtRefreshService,
            IRequestMetadataService metadataService, MangoPostgresDbContext postgresDbContext)
        {
            _cookieService = cookieService;
            _jwtRefreshService = jwtRefreshService;
            _metadataService = metadataService;
            _postgresDbContext = postgresDbContext;
        }

        public async Task<CreateChatEntityResponse> Handle(CreateDirectChatCommand request,
            CancellationToken cancellationToken)
        {
            // TODO: validate request user ID. Check if exists in DB.
            var partner = await _postgresDbContext
                .Users
                .FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);
            
            var requestMetadata = _metadataService.GetRequestMetadata();
            var refreshTokenId = _cookieService.Get(CookieConstants.MangoRefreshTokenId);

            var validationResult = await _jwtRefreshService.VerifyUserRefreshTokenAsync(refreshTokenId,
                requestMetadata,
                cancellationToken);

            if (validationResult.IsSuspicious)
            {
                return CreateChatEntityResponse.Suspicious;
            }

            if (!validationResult.Success)
            {
                return CreateChatEntityResponse.RefreshTokenNotValidated;
            }

            var currentUser = await _postgresDbContext
                .Users
                .FirstAsync(x => x.Id == validationResult.RefreshToken.UserId, cancellationToken);

            var directChatEntity = new ChatEntity
            {
                ChatType = ChatType.DirectChat,
                Title = $"{currentUser.DisplayName} / {partner.DisplayName}"
            };

            await _postgresDbContext.Chats.AddAsync(directChatEntity, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            _postgresDbContext.UserChats.AddRange(
                new UserChatEntity {ChatId = directChatEntity.Id, RoleId = UserRole.User, UserId = currentUser.Id},
                new UserChatEntity {ChatId = directChatEntity.Id, RoleId = UserRole.User, UserId = request.UserId});

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return CreateChatEntityResponse.DirectChatCreateSuccess;
        }
    }
}
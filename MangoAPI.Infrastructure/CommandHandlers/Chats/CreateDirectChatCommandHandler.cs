using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MangoAPI.DTO.Commands.Chats;
using MangoAPI.DTO.Responses.Chats;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.CommandHandlers.Chats
{
    public class CreateDirectChatCommandHandler : IRequestHandler<CreateDirectChatCommand, CreateChatEntityResponse>
    {
        private readonly IRequestMetadataService _metadataService;
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly UserManager<UserEntity> _userManager;

        public CreateDirectChatCommandHandler(IRequestMetadataService metadataService,
            MangoPostgresDbContext postgresDbContext, UserManager<UserEntity> userManager)
        {
            _metadataService = metadataService;
            _postgresDbContext = postgresDbContext;
            _userManager = userManager;
        }

        public async Task<CreateChatEntityResponse> Handle(CreateDirectChatCommand request,
            CancellationToken cancellationToken)
        {
            var partner = await _userManager.FindByIdAsync(request.PartnerId);

            if (partner == null)
            {
                return CreateChatEntityResponse.UserNotFound;
            }

            var currentUser = await _metadataService.GetUserFromRequestMetadataAsync();

            var directChatEntity = new ChatEntity
            {
                ChatType = ChatType.DirectChat,
                Title = $"{currentUser.DisplayName} / {partner.DisplayName}",
                Created = DateTime.Now,
                MembersCount = 2
            };

            var userPrivateChats = _postgresDbContext.Chats
                .Include(chatEntity => chatEntity.ChatUsers)
                .Where(chatEntity => chatEntity.ChatType == ChatType.DirectChat && chatEntity.ChatUsers
                    .Any(userChatEntity => userChatEntity.UserId == currentUser.Id)).ToList();

            var directChatAlreadyExists =
                userPrivateChats.Any(x => x.ChatUsers
                    .Any(t => t.UserId == partner.Id));

            if (directChatAlreadyExists)
            {
                return CreateChatEntityResponse.DirectChatAlreadyExists;
            }

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
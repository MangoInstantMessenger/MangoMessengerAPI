﻿using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MangoAPI.DTO.ApiCommands.Chats;
using MangoAPI.DTO.Responses.Chats;
using MangoAPI.Infrastructure.BusinessExceptions;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Infrastructure.CommandHandlers.Chats
{
    public class CreateGroupCommandHandler : IRequestHandler<CreateGroupCommand, CreateChatEntityResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly UserManager<UserEntity> _userManager;

        public CreateGroupCommandHandler(MangoPostgresDbContext postgresDbContext, UserManager<UserEntity> userManager)
        {
            _postgresDbContext = postgresDbContext;
            _userManager = userManager;
        }

        public async Task<CreateChatEntityResponse> Handle(CreateGroupCommand request,
            CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var group = new ChatEntity
            {
                Id = Guid.NewGuid().ToString(),
                ChatType = request.GroupType,
                Title = request.GroupTitle,
                Created = DateTime.UtcNow,
                MembersCount = 1
            };

            await _postgresDbContext.Chats.AddAsync(group, cancellationToken);

            await _postgresDbContext.UserChats.AddAsync(UserChatEntity.Create(user.Id, group.Id, UserRole.Owner),
                cancellationToken);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return CreateChatEntityResponse.FromSuccess(group);
        }
    }
}
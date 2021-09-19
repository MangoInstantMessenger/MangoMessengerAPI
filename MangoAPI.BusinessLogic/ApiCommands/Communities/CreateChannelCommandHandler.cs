using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public class CreateChannelCommandHandler : IRequestHandler<CreateChannelCommand, CreateCommunityResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public CreateChannelCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<CreateCommunityResponse> Handle(CreateChannelCommand request,
            CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.FindUserByIdAsync(request.UserId, cancellationToken);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            if (request.CommunityType is CommunityType.DirectChat or CommunityType.SecretChat)
            {
                throw new BusinessException(ResponseMessageCodes.InvalidGroupType);
            }

            var group = new ChatEntity
            {
                CommunityType = (int) request.CommunityType,
                Title = request.ChannelTitle,
                CreatedAt = DateTime.UtcNow,
                Description = request.ChannelDescription,
                MembersCount = 1,
            };

            await _postgresDbContext.Chats.AddAsync(group, cancellationToken);

            _postgresDbContext.UserChats.Add(new UserChatEntity
            {
                ChatId = group.Id,
                RoleId = (int) UserRole.Owner,
                UserId = user.Id,
            });

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return CreateCommunityResponse.FromSuccess(group);
        }
    }
}
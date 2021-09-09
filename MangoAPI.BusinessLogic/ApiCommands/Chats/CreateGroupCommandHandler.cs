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

namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    public class CreateGroupCommandHandler : IRequestHandler<CreateGroupCommand, CreateChatEntityResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public CreateGroupCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<CreateChatEntityResponse> Handle(CreateGroupCommand request,
            CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.FindUserByIdAsync(request.UserId, cancellationToken);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            if (request.GroupType == ChatType.DirectChat)
            {
                throw new BusinessException(ResponseMessageCodes.InvalidGroupType);
            }

            var group = new ChatEntity
            {
                ChatType = request.GroupType,
                Title = request.GroupTitle,
                CreatedAt = DateTime.UtcNow,
                Description = request.GroupDescription,
                MembersCount = 1,
            };

            await _postgresDbContext.Chats.AddAsync(group, cancellationToken);

            _postgresDbContext.UserChats.Add(new UserChatEntity
            {
                ChatId = group.Id, RoleId = UserRole.Owner, UserId = user.Id,
            });

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return CreateChatEntityResponse.FromSuccess(group);
        }
    }
}
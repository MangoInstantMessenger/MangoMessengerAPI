namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using MangoAPI.BusinessLogic.BusinessExceptions;
    using MangoAPI.DataAccess.Database;
    using MangoAPI.Domain.Constants;
    using MangoAPI.Domain.Entities;
    using MangoAPI.Domain.Enums;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    public class CreateGroupCommandHandler : IRequestHandler<CreateGroupCommand, CreateChatEntityResponse>
    {
        private readonly MangoPostgresDbContext postgresDbContext;

        public CreateGroupCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            this.postgresDbContext = postgresDbContext;
        }

        public async Task<CreateChatEntityResponse> Handle(
            CreateGroupCommand request,
            CancellationToken cancellationToken)
        {
            var user = await postgresDbContext.Users.FirstOrDefaultAsync(
                x => x.Id == request.UserId,
                cancellationToken);

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
                Id = Guid.NewGuid().ToString(),
                ChatType = request.GroupType,
                Title = request.GroupTitle,
                Created = DateTime.UtcNow,
                MembersCount = 1,
            };

            await postgresDbContext.Chats.AddAsync(group, cancellationToken);

            postgresDbContext.UserChats.Add(new UserChatEntity
            {
                ChatId = group.Id, RoleId = UserRole.Owner, UserId = user.Id,
            });

            await postgresDbContext.SaveChangesAsync(cancellationToken);

            return CreateChatEntityResponse.FromSuccess(group);
        }
    }
}

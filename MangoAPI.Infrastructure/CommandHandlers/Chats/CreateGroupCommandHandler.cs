using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MangoAPI.DTO.Commands.Chats;
using MangoAPI.DTO.Responses.Chats;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.CommandHandlers.Chats
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
            if (request.GroupTitle == null)
            {
                return CreateChatEntityResponse.InvalidOrEmptyChatTitle;
            }

            if (request.GroupType == ChatType.DirectChat)
            {
                return CreateChatEntityResponse.InvalidGroupType;
            }

            var currentUser = await _postgresDbContext
                .Users
                .FirstAsync(x => x.Id == request.UserId, cancellationToken);

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
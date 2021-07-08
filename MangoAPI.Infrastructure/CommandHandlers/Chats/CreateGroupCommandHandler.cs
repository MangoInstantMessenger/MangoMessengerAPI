using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
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
        private readonly IRequestMetadataService _metadataService;

        public CreateGroupCommandHandler(MangoPostgresDbContext postgresDbContext, IRequestMetadataService metadataService)
        {
            _postgresDbContext = postgresDbContext;
            _metadataService = metadataService;
        }

        public async Task<CreateChatEntityResponse> Handle(CreateGroupCommand request,
            CancellationToken cancellationToken)
        {
            if (request.GroupTitle == null)
            {
                return CreateChatEntityResponse.InvalidOrEmptyChatTitle;
            }

            var groupType = Convert.ToInt32(request.GroupType);

            if (groupType > 4 || groupType < 2)
                return CreateChatEntityResponse.InvalidGroupType;

            var currentUser = await _metadataService.GetUserFromRequestMetadataAsync();

            var directChatEntity = new ChatEntity
            {
                ChatType = request.GroupType,
                Title = request.GroupTitle,
                Created = DateTime.Now
            };

            await _postgresDbContext.Chats.AddAsync(directChatEntity, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            _postgresDbContext.UserChats.Add(new UserChatEntity
            {
                ChatId = directChatEntity.Id, RoleId = UserRole.Owner, UserId = currentUser.Id
            });

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return CreateChatEntityResponse.SuccessResponse;
        }
    }
}
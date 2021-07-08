using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.DTO.Queries.Chats;
using MangoAPI.DTO.Responses.Chats;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.QueryHandlers.Chats
{
    public class GetChatsQueryHandler : IRequestHandler<GetChatsQuery, GetChatsResponse>
    {
        private readonly IRequestMetadataService _metadataService;
        private readonly MangoPostgresDbContext _postgresDbContext;

        public GetChatsQueryHandler(IRequestMetadataService metadataService, MangoPostgresDbContext postgresDbContext)
        {
            _metadataService = metadataService;
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GetChatsResponse> Handle(GetChatsQuery request, CancellationToken cancellationToken)
        {
            var currentUser = await _metadataService.GetUserFromRequestMetadataAsync();

            if (currentUser == null)
            {
                return GetChatsResponse.UserNotFound;
            }

            var chats = _postgresDbContext.UserChats
                .Include(x => x.Chat)
                .ThenInclude(x => x.Messages)
                .Where(x => x.UserId == currentUser.Id)
                .ToList();

            return GetChatsResponse.FromSuccess(chats);
        }
    }
}
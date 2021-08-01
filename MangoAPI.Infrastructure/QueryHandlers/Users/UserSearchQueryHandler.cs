using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.ApiQueries.Users;
using MangoAPI.DTO.Responses.Users;
using MangoAPI.Infrastructure.BusinessExceptions;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.QueryHandlers.Users
{
    public class UserSearchQueryHandler : IRequestHandler<UserSearchQuery, UserSearchResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public UserSearchQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }
        
        public async Task<UserSearchResponse> Handle(UserSearchQuery request, CancellationToken cancellationToken)
        {
            var users = await _postgresDbContext.Users.Where(x => x.DisplayName.Contains(request.DisplayName))
                .ToListAsync(cancellationToken);

            return UserSearchResponse.FromSuccess(users);
        }
        
    }
}
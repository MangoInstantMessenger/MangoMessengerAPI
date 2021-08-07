using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.ApiQueries.Contacts;
using MangoAPI.DTO.Responses.Contacts;
using MangoAPI.Infrastructure.BusinessExceptions;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.QueryHandlers.Contacts
{
    public class GetContactsQueryHandler : IRequestHandler<GetContactsQuery, GetContactsResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly UserManager<UserEntity> _userManager;

        public GetContactsQueryHandler(MangoPostgresDbContext postgresDbContext,
            UserManager<UserEntity> userManager)
        {
            _postgresDbContext = postgresDbContext;
            _userManager = userManager;
        }
        
        public async Task<GetContactsResponse> Handle(GetContactsQuery request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId);

            if (user is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var contacts = await _postgresDbContext.UserContacts
                .AsNoTracking()
                .Include(x => x.User)
                .Where(x => x.UserId == request.UserId)
                .ToListAsync(cancellationToken);
            
            return GetContactsResponse.FromSuccess(contacts);
        }
    }
}
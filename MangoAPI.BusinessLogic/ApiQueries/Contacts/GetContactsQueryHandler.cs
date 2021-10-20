using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.DataAccess.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
    public class GetContactsQueryHandler 
        : IRequestHandler<GetContactsQuery, GenericResponse<GetContactsResponse, ErrorResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public GetContactsQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GenericResponse<GetContactsResponse,ErrorResponse>> Handle(GetContactsQuery request, CancellationToken cancellationToken)
        {
            var query = from userContact in _postgresDbContext.UserContacts.AsNoTracking()
                        join userEntity in _postgresDbContext.Users.Include(x => x.UserInformation)
                            on userContact.ContactId equals userEntity.Id
                        where userContact.UserId == request.UserId
                        orderby userContact.CreatedAt
                        select new Contact
                        {
                            UserId = userEntity.Id,
                            DisplayName = userEntity.DisplayName,
                            Address = userEntity.UserInformation.Address,
                            Bio = userEntity.Bio,
                            PictureUrl = StringService.GetDocumentUrl(userEntity.Image),
                            Email = userEntity.Email,
                            PhoneNumber = userEntity.PhoneNumber,
                            IsContact = true,
                        };

            var contacts = await query.Take(200).ToListAsync(cancellationToken);

            return new GenericResponse<GetContactsResponse, ErrorResponse>
            {
                Error = null,
                Response = GetContactsResponse.FromSuccess(contacts),
                StatusCode = 200
            };
        }
    }
}
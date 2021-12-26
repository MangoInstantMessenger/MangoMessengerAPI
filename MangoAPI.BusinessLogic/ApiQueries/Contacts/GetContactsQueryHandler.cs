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
    public class GetContactsQueryHandler : IRequestHandler<GetContactsQuery, Result<GetContactsResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly ResponseFactory<GetContactsResponse> _responseFactory;
        private readonly StringService _stringService;

        public GetContactsQueryHandler(MangoPostgresDbContext postgresDbContext,
            ResponseFactory<GetContactsResponse> responseFactory, StringService stringService)
        {
            _postgresDbContext = postgresDbContext;
            _responseFactory = responseFactory;
            _stringService = stringService;
        }

        public async Task<Result<GetContactsResponse>> Handle(GetContactsQuery request, CancellationToken cancellationToken)
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
                            PictureUrl = _stringService.GetDocumentUrl(userEntity.Image),
                            Email = userEntity.Email,
                            IsContact = true,
                        };

            var contacts = await query.Take(200).ToListAsync(cancellationToken);

            return _responseFactory.SuccessResponse(GetContactsResponse.FromSuccess(contacts));
        }
    }
}
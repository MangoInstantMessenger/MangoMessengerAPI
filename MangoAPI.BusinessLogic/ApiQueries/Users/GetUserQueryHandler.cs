using System.Linq;
using System.Net;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiQueries.Users
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, Result<GetUserResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public GetUserQueryHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<Result<GetUserResponse>> Handle(GetUserQuery request, 
            CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.AsNoTracking()
                .Include(x => x.UserInformation)
                .Select(user => new User
                {
                    UserId = user.Id,
                    DisplayName = user.DisplayName,
                    Address = user.UserInformation.Address,
                    BirthdayDate = user.UserInformation.BirthDay.HasValue
                        ? user.UserInformation.BirthDay.Value.ToString("yyyy-MM-dd")
                        : null,
                    PhoneNumber = user.PhoneNumber,
                    Email = user.Email,
                    Website = user.UserInformation.Website,
                    Facebook = user.UserInformation.Facebook,
                    Twitter = user.UserInformation.Twitter,
                    Instagram = user.UserInformation.Instagram,
                    LinkedIn = user.UserInformation.LinkedIn,
                    Username = user.UserName,
                    Bio = user.Bio,
                    PictureUrl = StringService.GetDocumentUrl(user.Image),
                }).FirstOrDefaultAsync(x => x.UserId == request.UserId, cancellationToken);

            if (user is null)
            {
                return new Result<GetUserResponse>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.UserNotFound,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.UserNotFound],
                        Success = false,
                        StatusCode = HttpStatusCode.Conflict
                    },
                    Response = null,
                    StatusCode = HttpStatusCode.Conflict
                };
            }

            return new Result<GetUserResponse>
            {
                Error = null,
                Response = GetUserResponse.FromSuccess(user),
                StatusCode = HttpStatusCode.OK
            };
        }
    }
}
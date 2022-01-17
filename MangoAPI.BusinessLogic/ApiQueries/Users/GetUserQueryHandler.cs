using System.Linq;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiQueries.Users;

public class GetUserQueryHandler : IRequestHandler<GetUserQuery, Result<GetUserResponse>>
{
    private readonly MangoPostgresDbContext _postgresDbContext;
    private readonly ResponseFactory<GetUserResponse> _responseFactory;

    public GetUserQueryHandler(
        MangoPostgresDbContext postgresDbContext,
        ResponseFactory<GetUserResponse> responseFactory)
    {
        _postgresDbContext = postgresDbContext;
        _responseFactory = responseFactory;
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
            const string errorMessage = ResponseMessageCodes.UserNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return _responseFactory.ConflictResponse(errorMessage, details);
        }

        return _responseFactory.SuccessResponse(GetUserResponse.FromSuccess(user));
    }
}
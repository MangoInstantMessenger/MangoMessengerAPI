using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class UpdateProfilePictureCommandHandler
        : IRequestHandler<UpdateProfilePictureCommand, Result<ResponseBase>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly ResponseFactory<ResponseBase> _responseFactory;

        public UpdateProfilePictureCommandHandler(MangoPostgresDbContext postgresDbContext,
            ResponseFactory<ResponseBase> responseFactory)
        {
            _postgresDbContext = postgresDbContext;
            _responseFactory = responseFactory;
        }

        public async Task<Result<ResponseBase>> Handle(UpdateProfilePictureCommand request,
            CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users
                .FirstOrDefaultAsync(userEntity => userEntity.Id == request.UserId, 
                    cancellationToken);

            if (user == null)
            {
                const string errorMessage = ResponseMessageCodes.UserNotFound;
                var details = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, details);
            }

            user.Image = request.Image;

            _postgresDbContext.Users.Update(user);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
        }
    }
}
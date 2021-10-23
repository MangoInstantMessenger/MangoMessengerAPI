using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class UpdateProfilePictureCommandHandler 
        : IRequestHandler<UpdateProfilePictureCommand, GenericResponse<ResponseBase>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public UpdateProfilePictureCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GenericResponse<ResponseBase>> Handle(UpdateProfilePictureCommand request, 
            CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.FindUserByIdAsync(request.UserId, cancellationToken);

            if (user == null)
            {
                return new GenericResponse<ResponseBase>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.UserNotFound,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.UserNotFound],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            user.Image = request.Image;

            _postgresDbContext.Users.Update(user);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return new GenericResponse<ResponseBase>
            {
                Error = null,
                Response = ResponseBase.SuccessResponse,
                StatusCode = 200
            };
        }
    }
}
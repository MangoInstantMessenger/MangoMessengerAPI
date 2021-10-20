using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Contacts
{
    public class DeleteContactCommandHandler 
        : IRequestHandler<DeleteContactCommand, GenericResponse<ResponseBase,ErrorResponse>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public DeleteContactCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GenericResponse<ResponseBase,ErrorResponse>> Handle(DeleteContactCommand request, CancellationToken cancellationToken)
        {
            var user = await _postgresDbContext.Users.FindUserByIdAsync(request.UserId, cancellationToken);

            if (user is null)
            {
                return new GenericResponse<ResponseBase, ErrorResponse>
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

            var userContacts = await _postgresDbContext
                .UserContacts
                .GetUserContactsAsync(user.Id, cancellationToken);

            var contact = userContacts.FirstOrDefault(x => x.ContactId == request.ContactId);

            if (contact is null)
            {
                return new GenericResponse<ResponseBase, ErrorResponse>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.ContactNotFound,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.ContactNotFound],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            _postgresDbContext.UserContacts.Remove(contact);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return new GenericResponse<ResponseBase, ErrorResponse>
            {
                Error = null,
                Response = ResponseBase.SuccessResponse,
                StatusCode = 200
            };
        }
    }
}
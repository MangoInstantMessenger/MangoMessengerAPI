using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Contacts
{
    public class AddContactCommandHandler 
        : IRequestHandler<AddContactCommand, GenericResponse<ResponseBase>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public AddContactCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<GenericResponse<ResponseBase>> Handle(AddContactCommand request, 
            CancellationToken cancellationToken)
        {
            if (request.UserId == request.ContactId)
            {
                return new GenericResponse<ResponseBase>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.CannotAddSelfToContacts,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.CannotAddSelfToContacts],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            var userContactExist = await _postgresDbContext.UserContacts
                .IsContactExistAsync(request.UserId, request.ContactId, cancellationToken);

            if (userContactExist)
            {
                return new GenericResponse<ResponseBase>
                {
                    Error = new ErrorResponse
                    {
                        ErrorMessage = ResponseMessageCodes.ContactAlreadyExist,
                        ErrorDetails = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.ContactAlreadyExist],
                        Success = false,
                        StatusCode = 409
                    },
                    Response = null,
                    StatusCode = 409
                };
            }

            var contactEntity = new UserContactEntity
            {
                ContactId = request.ContactId,
                UserId = request.UserId,
                CreatedAt = DateTime.UtcNow,
            };

            _postgresDbContext.UserContacts.Add(contactEntity);
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
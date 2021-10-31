using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.ApiCommands.Contacts
{
    public class AddContactCommandHandler
        : IRequestHandler<AddContactCommand, Result<ResponseBase>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly ResponseFactory<ResponseBase> _responseFactory;

        public AddContactCommandHandler(MangoPostgresDbContext postgresDbContext, ResponseFactory<ResponseBase> responseFactory)
        {
            _postgresDbContext = postgresDbContext;
            _responseFactory = responseFactory;
        }

        public async Task<Result<ResponseBase>> Handle(AddContactCommand request,
            CancellationToken cancellationToken)
        {
            var contact = await _postgresDbContext.Users.FindUserByIdAsync(request.ContactId, cancellationToken);

            if (contact is null)
            {
                const string errorMessage = ResponseMessageCodes.ContactNotFound;
                var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, errorDescription);
            }

            if (request.UserId == request.ContactId)
            {
                const string errorMessage = ResponseMessageCodes.CannotAddSelfToContacts;
                var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, errorDescription);
            }

            var userContactExist = await _postgresDbContext.UserContacts
                .IsContactExistAsync(request.UserId, request.ContactId, cancellationToken);

            if (userContactExist)
            {
                const string errorMessage = ResponseMessageCodes.ContactAlreadyExist;
                var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, errorDescription);
            }

            var contactEntity = new UserContactEntity
            {
                ContactId = request.ContactId,
                UserId = request.UserId,
                CreatedAt = DateTime.UtcNow,
            };

            _postgresDbContext.UserContacts.Add(contactEntity);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
        }
    }
}
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
                const string message = ResponseMessageCodes.ContactNotFound;
                var description = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.ContactNotFound];

                return _responseFactory.ConflictResponse(message, description);
            }

            if (request.UserId == request.ContactId)
            {
                const string message = ResponseMessageCodes.CannotAddSelfToContacts;
                var description = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.CannotAddSelfToContacts];

                return _responseFactory.ConflictResponse(message, description);
            }

            var userContactExist = await _postgresDbContext.UserContacts
                .IsContactExistAsync(request.UserId, request.ContactId, cancellationToken);

            if (userContactExist)
            {
                const string message = ResponseMessageCodes.ContactAlreadyExist;
                var description = ResponseMessageCodes.ErrorDictionary[ResponseMessageCodes.ContactAlreadyExist];

                return _responseFactory.ConflictResponse(message, description);
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
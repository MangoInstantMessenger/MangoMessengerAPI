using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Contacts
{
    public class AddContactCommandHandler
        : IRequestHandler<AddContactCommand, Result<ResponseBase>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly ResponseFactory<ResponseBase> _responseFactory;

        public AddContactCommandHandler(MangoPostgresDbContext postgresDbContext, 
            ResponseFactory<ResponseBase> responseFactory)
        {
            _postgresDbContext = postgresDbContext;
            _responseFactory = responseFactory;
        }

        public async Task<Result<ResponseBase>> Handle(AddContactCommand request, CancellationToken cancellationToken)
        {
            var contactToAdd = await _postgresDbContext.Users
                .FirstOrDefaultAsync(x => x.Id == request.ContactId, 
                    cancellationToken);

            if (contactToAdd is null)
            {
                const string errorMessage = ResponseMessageCodes.UserNotFound;
                var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, errorDescription);
            }

            if (request.UserId == request.ContactId)
            {
                const string errorMessage = ResponseMessageCodes.CannotAddSelfToContacts;
                var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

                return _responseFactory.ConflictResponse(errorMessage, errorDescription);
            }

            var contactExist = await _postgresDbContext.UserContacts
                .AnyAsync(userContactEntity => 
                    userContactEntity.ContactId == request.ContactId && 
                    userContactEntity.UserId == request.UserId, cancellationToken);

            if (contactExist)
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
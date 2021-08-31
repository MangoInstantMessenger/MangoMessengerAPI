using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.DataAccess.Database.Extensions;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Contacts
{
    public class AddContactCommandHandler : IRequestHandler<AddContactCommand, ResponseBase>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public AddContactCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<ResponseBase> Handle(AddContactCommand request, CancellationToken cancellationToken)
        {
            var contact = await _postgresDbContext.Users.FindUserByIdAsync(request.UserId, cancellationToken);

            if (contact is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            if (request.UserId == request.ContactId)
            {
                throw new BusinessException(ResponseMessageCodes.CannotAddSelfToContacts);
            }

            var userContactExist = await _postgresDbContext.UserContacts
                .IsContactExistAsync(request.UserId, request.ContactId, cancellationToken);

            if (userContactExist)
            {
                throw new BusinessException(ResponseMessageCodes.ContactAlreadyExist);
            }

            var contactEntity = new UserContactEntity
            {
                Id = Guid.NewGuid().ToString(),
                ContactId = request.ContactId,
                UserId = request.UserId,
            };

            await _postgresDbContext.UserContacts.AddAsync(contactEntity, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return ResponseBase.SuccessResponse;
        }
    }
}
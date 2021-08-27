using MangoAPI.DataAccess.Database.Extensions;

namespace MangoAPI.BusinessLogic.ApiCommands.Contacts
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using BusinessExceptions;
    using DataAccess.Database;
    using Domain.Constants;
    using Domain.Entities;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    public class AddContactCommandHandler : IRequestHandler<AddContactCommand, AddContactResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public AddContactCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<AddContactResponse> Handle(AddContactCommand request, CancellationToken cancellationToken)
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

            return AddContactResponse.SuccessResponse;
        }
    }
}

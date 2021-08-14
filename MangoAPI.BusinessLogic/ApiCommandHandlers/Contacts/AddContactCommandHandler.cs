using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Contacts;
using MangoAPI.BusinessLogic.BusinessExceptions;
using MangoAPI.BusinessLogic.Responses.Contacts;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommandHandlers.Contacts
{
    public class AddContactCommandHandler : IRequestHandler<AddContactCommand, AddContactResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public AddContactCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<AddContactResponse> Handle(AddContactCommand request, CancellationToken cancellationToken)
        {
            var contact = await _postgresDbContext.Users
                .FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);

            if (contact is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var contactEntity = new UserContactEntity
            {
                Id = Guid.NewGuid().ToString(),
                ContactId = request.ContactId,
                UserId = request.UserId
            };

            var userContactExist = await _postgresDbContext.UserContacts
                .Where(x => x.UserId == request.UserId)
                .AnyAsync(x => x.ContactId == request.ContactId, cancellationToken);

            if (userContactExist)
            {
                throw new BusinessException(ResponseMessageCodes.ContactAlreadyExist);
            }

            await _postgresDbContext.UserContacts.AddAsync(contactEntity, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return AddContactResponse.SuccessResponse;
        }
    }
}
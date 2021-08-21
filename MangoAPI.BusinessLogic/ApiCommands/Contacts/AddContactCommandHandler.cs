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
        private readonly MangoPostgresDbContext postgresDbContext;

        public AddContactCommandHandler(MangoPostgresDbContext postgresDbContext)
        {
            this.postgresDbContext = postgresDbContext;
        }

        public async Task<AddContactResponse> Handle(AddContactCommand request, CancellationToken cancellationToken)
        {
            var contact = await postgresDbContext.Users
                .FirstOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);

            if (contact is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var contactEntity = new UserContactEntity
            {
                Id = Guid.NewGuid().ToString(),
                ContactId = request.ContactId,
                UserId = request.UserId,
            };

            var userContactExist = await postgresDbContext.UserContacts
                .Where(x => x.UserId == request.UserId)
                .AnyAsync(x => x.ContactId == request.ContactId, cancellationToken);

            if (userContactExist)
            {
                throw new BusinessException(ResponseMessageCodes.ContactAlreadyExist);
            }

            await postgresDbContext.UserContacts.AddAsync(contactEntity, cancellationToken);
            await postgresDbContext.SaveChangesAsync(cancellationToken);

            return AddContactResponse.SuccessResponse;
        }
    }
}

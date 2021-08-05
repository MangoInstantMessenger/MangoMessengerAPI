using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.ApiCommands.Contacts;
using MangoAPI.DTO.Responses.Contacts;
using MangoAPI.Infrastructure.BusinessExceptions;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Infrastructure.CommandHandlers.Contacts
{
    public class AddContactCommandHandler : IRequestHandler<AddContactCommand, AddContactResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly UserManager<UserEntity> _userManager;

        public AddContactCommandHandler(MangoPostgresDbContext postgresDbContext,
            UserManager<UserEntity> userManager)
        {
            _postgresDbContext = postgresDbContext;
            _userManager = userManager;
        }
        
        public async Task<AddContactResponse> Handle(AddContactCommand request, CancellationToken cancellationToken)
        {
            var contact = await _userManager.FindByIdAsync(request.ContactId);

            if (contact is null)
            {
                throw new BusinessException(ResponseMessageCodes.UserNotFound);
            }

            var contactEntity = new UserContactEntity()
            {
                Id = Guid.NewGuid().ToString(),
                ContactId = request.ContactId,
                UserId = request.UserId
            };

            var userContactExist = _postgresDbContext.UserContacts
                .Where(x => x.UserId == request.UserId)
                .Any(x => x.ContactId == contact.Id);

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
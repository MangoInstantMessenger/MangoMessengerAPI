﻿using System;
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
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommandHandlers.Contacts
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
            await using var transaction = await _postgresDbContext.Database.BeginTransactionAsync(cancellationToken);
            try
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

                var userContactExist = await _postgresDbContext.UserContacts
                    .Where(x => x.UserId == request.UserId)
                    .AnyAsync(x => x.ContactId == contact.Id, cancellationToken);

                if (userContactExist)
                {
                    throw new BusinessException(ResponseMessageCodes.ContactAlreadyExist);
                }

                await _postgresDbContext.UserContacts.AddAsync(contactEntity, cancellationToken);
                await _postgresDbContext.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);
            
                return AddContactResponse.SuccessResponse;
            }
            catch (Exception)
            {
                await transaction.RollbackAsync(cancellationToken);
                throw new BusinessException(ResponseMessageCodes.DatabaseError);
            }
            
        }
    }
}
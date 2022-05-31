using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Contacts;

public class AddContactCommandHandler
    : IRequestHandler<AddContactCommand, Result<ResponseBase>>
{
    private readonly MangoDbContext _dbContext;
    private readonly ResponseFactory<ResponseBase> _responseFactory;

    public AddContactCommandHandler(MangoDbContext dbContext, 
        ResponseFactory<ResponseBase> responseFactory)
    {
        _dbContext = dbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(AddContactCommand request, CancellationToken cancellationToken)
    {
        var contactToAdd = await _dbContext.Users
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

        var contactExist = await _dbContext.UserContacts
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

        _dbContext.UserContacts.Add(contactEntity);
        await _dbContext.SaveChangesAsync(cancellationToken);

        return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
    }
}
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Contacts;

public class AddContactCommandHandler
    : IRequestHandler<AddContactCommand, Result<ResponseBase>>
{
    private readonly MangoDbContext dbContext;
    private readonly ResponseFactory<ResponseBase> responseFactory;

    public AddContactCommandHandler(
        MangoDbContext dbContext,
        ResponseFactory<ResponseBase> responseFactory)
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(AddContactCommand request, CancellationToken cancellationToken)
    {
        var contactToAdd = await dbContext.Users
            .FirstOrDefaultAsync(
                x => x.Id == request.ContactId,
                cancellationToken);

        if (contactToAdd == null)
        {
            const string errorMessage = ResponseMessageCodes.UserNotFound;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        if (request.UserId == request.ContactId)
        {
            const string errorMessage = ResponseMessageCodes.CannotAddSelfToContacts;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        var contactExist = await dbContext.UserContacts
            .AnyAsync(
                userContactEntity =>
                    userContactEntity.ContactId == request.ContactId &&
                    userContactEntity.UserId == request.UserId, cancellationToken);

        if (contactExist)
        {
            const string errorMessage = ResponseMessageCodes.ContactAlreadyExist;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        var contactEntity = ContactEntity.Create(request.UserId, request.ContactId);

        dbContext.UserContacts.Add(contactEntity);
        await dbContext.SaveChangesAsync(cancellationToken);

        return responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
    }
}
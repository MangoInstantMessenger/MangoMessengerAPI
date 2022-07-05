using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.Contacts;

public class DeleteContactCommandHandler
    : IRequestHandler<DeleteContactCommand, Result<ResponseBase>>
{
    private readonly MangoDbContext dbContext;
    private readonly ResponseFactory<ResponseBase> responseFactory;

    public DeleteContactCommandHandler(MangoDbContext dbContext,
        ResponseFactory<ResponseBase> responseFactory)
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(DeleteContactCommand request,
        CancellationToken cancellationToken)
    {
        var user = await dbContext.Users
            .FirstOrDefaultAsync(userEntity => userEntity.Id == request.UserId,
                cancellationToken);

        if (user is null)
        {
            const string errorMessage = ResponseMessageCodes.UserNotFound;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        var userContacts = await dbContext.UserContacts
            .Where(x => x.UserId == user.Id)
            .ToListAsync(cancellationToken);

        var contact = userContacts.FirstOrDefault(x => x.ContactId == request.ContactId);

        if (contact is null)
        {
            const string errorMessage = ResponseMessageCodes.ContactNotFound;
            var errorDescription = ResponseMessageCodes.ErrorDictionary[errorMessage];

            return responseFactory.ConflictResponse(errorMessage, errorDescription);
        }

        dbContext.UserContacts.Remove(contact);
        await dbContext.SaveChangesAsync(cancellationToken);

        return responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
    }
}

using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;

public class
    DeclineKeyExchangeCommandHandler : IRequestHandler<DeclineKeyExchangeCommand, Result<ResponseBase>>
{
    private readonly MangoDbContext _mangoDbContext;
    private readonly ResponseFactory<ResponseBase> _responseFactory;

    public DeclineKeyExchangeCommandHandler(
        MangoDbContext mangoDbContext,
        ResponseFactory<ResponseBase> responseFactory)
    {
        _mangoDbContext = mangoDbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(DeclineKeyExchangeCommand request,
        CancellationToken cancellationToken)
    {
        var keyExchangeRequest =
            await _mangoDbContext.DiffieHellmanKeyExchangeEntities
                .FirstOrDefaultAsync(
                    predicate: x => x.Id == request.RequestId,
                    cancellationToken: cancellationToken);

        if (keyExchangeRequest == null)
        {
            const string message = ResponseMessageCodes.KeyExchangeRequestNotFound;
            var description = ResponseMessageCodes.ErrorDictionary[message];

            return _responseFactory.ConflictResponse(message, description);
        }

        if (keyExchangeRequest.ReceiverId != request.UserId)
        {
            const string message = ResponseMessageCodes.KeyExchangeDoesNotBelongToUser;
            var description = ResponseMessageCodes.ErrorDictionary[message];

            return _responseFactory.ConflictResponse(message, description);
        }

        _mangoDbContext.DiffieHellmanKeyExchangeEntities.Remove(keyExchangeRequest);

        await _mangoDbContext.SaveChangesAsync(cancellationToken);

        var result = ResponseBase.SuccessResponse;

        return _responseFactory.SuccessResponse(result);
    }
}
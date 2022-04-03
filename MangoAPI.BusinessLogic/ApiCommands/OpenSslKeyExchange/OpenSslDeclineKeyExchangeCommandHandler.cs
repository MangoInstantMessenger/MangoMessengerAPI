using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.OpenSslKeyExchange;

public class
    OpenSslDeclineKeyExchangeCommandHandler : IRequestHandler<OpenSslDeclineKeyExchangeCommand, Result<ResponseBase>>
{
    private readonly MangoPostgresDbContext _mangoPostgresDbContext;
    private readonly ResponseFactory<ResponseBase> _responseFactory;

    public OpenSslDeclineKeyExchangeCommandHandler(
        MangoPostgresDbContext mangoPostgresDbContext,
        ResponseFactory<ResponseBase> responseFactory)
    {
        _mangoPostgresDbContext = mangoPostgresDbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(OpenSslDeclineKeyExchangeCommand request,
        CancellationToken cancellationToken)
    {
        var keyExchangeRequest =
            await _mangoPostgresDbContext.OpenSslKeyExchangeRequests
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

        _mangoPostgresDbContext.OpenSslKeyExchangeRequests.Remove(keyExchangeRequest);

        await _mangoPostgresDbContext.SaveChangesAsync(cancellationToken);

        var result = ResponseBase.SuccessResponse;

        return _responseFactory.SuccessResponse(result);
    }
}
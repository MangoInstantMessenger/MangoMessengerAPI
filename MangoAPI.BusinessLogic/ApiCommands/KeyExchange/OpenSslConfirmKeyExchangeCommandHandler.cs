using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.KeyExchange;

public class
    OpenSslConfirmKeyExchangeCommandHandler : IRequestHandler<OpenSslConfirmKeyExchangeCommand, Result<ResponseBase>>
{
    private readonly MangoPostgresDbContext _mangoPostgresDbContext;
    private readonly ResponseFactory<ResponseBase> _responseFactory;

    public OpenSslConfirmKeyExchangeCommandHandler(MangoPostgresDbContext mangoPostgresDbContext,
        ResponseFactory<ResponseBase> responseFactory)
    {
        _mangoPostgresDbContext = mangoPostgresDbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(OpenSslConfirmKeyExchangeCommand request,
        CancellationToken cancellationToken)
    {
        var keyExchangeRequest = await _mangoPostgresDbContext.OpenSslKeyExchangeRequests
            .FirstOrDefaultAsync(
                predicate: x => x.Id == request.RequestId,
                cancellationToken: cancellationToken);

        if (keyExchangeRequest == null || keyExchangeRequest.ReceiverId != request.UserId)
        {
            const string message = ResponseMessageCodes.KeyExchangeRequestNotFound;
            var description = ResponseMessageCodes.ErrorDictionary[message];

            return _responseFactory.ConflictResponse(message, description);
        }

        if (!request.Confirmed)
        {
            keyExchangeRequest.IsConfirmed = false;

            await _mangoPostgresDbContext.SaveChangesAsync(cancellationToken);
            return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
        }

        await using var target = new MemoryStream();
        await request.ReceiverPublicKey.CopyToAsync(target, cancellationToken);

        var bytes = target.ToArray();

        keyExchangeRequest.ReceiverPublicKey = bytes;
        keyExchangeRequest.IsConfirmed = true;

        await _mangoPostgresDbContext.SaveChangesAsync(cancellationToken);
        return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
    }
}
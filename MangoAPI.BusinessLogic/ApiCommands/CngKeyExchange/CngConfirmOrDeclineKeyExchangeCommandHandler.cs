using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;

public class
    CngConfirmOrDeclineKeyExchangeCommandHandler : IRequestHandler<CngConfirmKeyExchangeCommand,
        Result<ResponseBase>>
{
    private readonly MangoDbContext _dbContext;
    private readonly ResponseFactory<ResponseBase> _responseFactory;

    public CngConfirmOrDeclineKeyExchangeCommandHandler(MangoDbContext dbContext,
        ResponseFactory<ResponseBase> responseFactory)
    {
        _dbContext = dbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(CngConfirmKeyExchangeCommand request,
        CancellationToken cancellationToken)
    {
        var keyExchangeRequest = await _dbContext.OpenSslKeyExchangeRequests
            .FirstOrDefaultAsync(x => x.Id == request.RequestId,
                cancellationToken);

        if (keyExchangeRequest == null)
        {
            const string message = ResponseMessageCodes.KeyExchangeRequestNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[message];

            return _responseFactory.ConflictResponse(message, details);
        }

        await using var target = new MemoryStream();
        await request.ReceiverPublicKey.CopyToAsync(target, cancellationToken);

        var bytes = target.ToArray();

        keyExchangeRequest.UpdatedAt = DateTime.UtcNow;
        keyExchangeRequest.IsConfirmed = true;
        keyExchangeRequest.ReceiverPublicKey = bytes;

        await _dbContext.SaveChangesAsync(cancellationToken);

        return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
    }
}
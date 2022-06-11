using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.OpenSslKeyExchange;

public class OpenSslCreateKeyExchangeCommandHandler : IRequestHandler<OpenSslCreateKeyExchangeCommand,
    Result<OpenSslCreateKeyExchangeResponse>>
{
    private readonly MangoDbContext _mangoDbContext;
    private readonly ResponseFactory<OpenSslCreateKeyExchangeResponse> _responseFactory;

    public OpenSslCreateKeyExchangeCommandHandler(MangoDbContext mangoDbContext,
        ResponseFactory<OpenSslCreateKeyExchangeResponse> responseFactory)
    {
        _mangoDbContext = mangoDbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<OpenSslCreateKeyExchangeResponse>> Handle(OpenSslCreateKeyExchangeCommand request,
        CancellationToken cancellationToken)
    {
        var requestAlreadyExists = await _mangoDbContext.OpenSslKeyExchangeRequests
            .AnyAsync(
                predicate: entity => entity.SenderId == request.SenderId && entity.ReceiverId == request.ReceiverId,
                cancellationToken: cancellationToken);

        if (requestAlreadyExists)
        {
            const string message = ResponseMessageCodes.KeyExchangeRequestAlreadyExists;
            var description = ResponseMessageCodes.ErrorDictionary[message];

            return _responseFactory.ConflictResponse(message, description);
        }

        await using var target = new MemoryStream();
        await request.SenderPublicKey.CopyToAsync(target, cancellationToken);

        var bytes = target.ToArray();

        var keyExchangeRequest = new OpenSslKeyExchangeRequestEntity
        {
            SenderId = request.SenderId,
            ReceiverId = request.ReceiverId,
            SenderPublicKey = bytes,
            CreatedAt = DateTime.UtcNow,
            KeyExchangeType = KeyExchangeType.OpenSsl
        };

        _mangoDbContext.OpenSslKeyExchangeRequests.Add(keyExchangeRequest);

        await _mangoDbContext.SaveChangesAsync(cancellationToken);

        var response = new OpenSslCreateKeyExchangeResponse
        {
            Message = ResponseMessageCodes.Success,
            RequestId = keyExchangeRequest.Id,
            Success = true
        };

        return _responseFactory.SuccessResponse(response);
    }
}
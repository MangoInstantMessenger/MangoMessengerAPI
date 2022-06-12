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

namespace MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;

public class CreateKeyExchangeCommandHandler : IRequestHandler<CreateKeyExchangeCommand,
    Result<CreateKeyExchangeResponse>>
{
    private readonly MangoDbContext _mangoDbContext;
    private readonly ResponseFactory<CreateKeyExchangeResponse> _responseFactory;

    public CreateKeyExchangeCommandHandler(MangoDbContext mangoDbContext,
        ResponseFactory<CreateKeyExchangeResponse> responseFactory)
    {
        _mangoDbContext = mangoDbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<CreateKeyExchangeResponse>> Handle(CreateKeyExchangeCommand request,
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

        var keyExchangeRequest = new DiffieHellmanKeyExchangeEntity
        {
            SenderId = request.SenderId,
            ReceiverId = request.ReceiverId,
            SenderPublicKey = bytes,
            CreatedAt = DateTime.UtcNow,
            KeyExchangeType = KeyExchangeType.OpenSsl
        };

        _mangoDbContext.OpenSslKeyExchangeRequests.Add(keyExchangeRequest);

        await _mangoDbContext.SaveChangesAsync(cancellationToken);

        var response = new CreateKeyExchangeResponse
        {
            Message = ResponseMessageCodes.Success,
            RequestId = keyExchangeRequest.Id,
            Success = true
        };

        return _responseFactory.SuccessResponse(response);
    }
}
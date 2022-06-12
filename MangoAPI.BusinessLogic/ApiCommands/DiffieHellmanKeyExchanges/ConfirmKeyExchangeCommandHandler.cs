using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;

public class
    ConfirmKeyExchangeCommandHandler : IRequestHandler<ConfirmKeyExchangeCommand, Result<ResponseBase>>
{
    private readonly MangoDbContext _mangoDbContext;
    private readonly ResponseFactory<ResponseBase> _responseFactory;

    public ConfirmKeyExchangeCommandHandler(MangoDbContext mangoDbContext,
        ResponseFactory<ResponseBase> responseFactory)
    {
        _mangoDbContext = mangoDbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(ConfirmKeyExchangeCommand request,
        CancellationToken cancellationToken)
    {
        var keyExchangeRequest = await _mangoDbContext.DiffieHellmanKeyExchangeEntities
            .FirstOrDefaultAsync(
                predicate: x => x.Id == request.RequestId,
                cancellationToken: cancellationToken);

        if (keyExchangeRequest == null || keyExchangeRequest.ReceiverId != request.UserId)
        {
            const string message = ResponseMessageCodes.KeyExchangeRequestNotFound;
            var description = ResponseMessageCodes.ErrorDictionary[message];

            return _responseFactory.ConflictResponse(message, description);
        }

        await using var target = new MemoryStream();
        await request.ReceiverPublicKey.CopyToAsync(target, cancellationToken);

        var bytes = target.ToArray();

        keyExchangeRequest.ReceiverPublicKey = bytes;
        keyExchangeRequest.IsConfirmed = true;
        keyExchangeRequest.UpdatedAt = DateTime.UtcNow;

        await _mangoDbContext.SaveChangesAsync(cancellationToken);
        return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
    }
}
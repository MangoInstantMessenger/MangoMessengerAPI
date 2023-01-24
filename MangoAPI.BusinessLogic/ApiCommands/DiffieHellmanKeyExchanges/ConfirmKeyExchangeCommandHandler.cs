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
    private readonly MangoDbContext mangoDbContext;
    private readonly ResponseFactory<ResponseBase> responseFactory;

    public ConfirmKeyExchangeCommandHandler(
        MangoDbContext mangoDbContext,
        ResponseFactory<ResponseBase> responseFactory)
    {
        this.mangoDbContext = mangoDbContext;
        this.responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(
        ConfirmKeyExchangeCommand request,
        CancellationToken cancellationToken)
    {
        var keyExchangeRequest = await mangoDbContext.DiffieHellmanKeyExchangeEntities
            .FirstOrDefaultAsync(
                predicate: x => x.Id == request.RequestId,
                cancellationToken: cancellationToken);

        if (keyExchangeRequest == null || keyExchangeRequest.ReceiverId != request.UserId)
        {
            const string message = ResponseMessageCodes.KeyExchangeRequestNotFound;
            var description = ResponseMessageCodes.ErrorDictionary[message];

            return responseFactory.ConflictResponse(message, description);
        }

        await using var target = new MemoryStream();
        await request.ReceiverPublicKey.CopyToAsync(target, cancellationToken);

        var bytes = target.ToArray();

        keyExchangeRequest.ReceiverPublicKey = bytes;
        keyExchangeRequest.IsConfirmed = true;
        keyExchangeRequest.UpdatedAt = DateTime.UtcNow;

        await mangoDbContext.SaveChangesAsync(cancellationToken);
        return responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
    }
}

﻿using System.Threading;
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
    private readonly MangoDbContext mangoDbContext;
    private readonly ResponseFactory<ResponseBase> responseFactory;

    public DeclineKeyExchangeCommandHandler(
        MangoDbContext mangoDbContext,
        ResponseFactory<ResponseBase> responseFactory)
    {
        this.mangoDbContext = mangoDbContext;
        this.responseFactory = responseFactory;
    }

    public async Task<Result<ResponseBase>> Handle(
        DeclineKeyExchangeCommand request,
        CancellationToken cancellationToken)
    {
        var keyExchangeRequest =
            await mangoDbContext.DiffieHellmanKeyExchangeEntities
                .FirstOrDefaultAsync(
                    x => x.Id == request.RequestId,
                    cancellationToken);

        if (keyExchangeRequest == null)
        {
            const string message = ResponseMessageCodes.KeyExchangeRequestNotFound;
            var description = ResponseMessageCodes.ErrorDictionary[message];

            return responseFactory.ConflictResponse(message, description);
        }

        if (keyExchangeRequest.ReceiverId != request.UserId)
        {
            const string message = ResponseMessageCodes.KeyExchangeDoesNotBelongToUser;
            var description = ResponseMessageCodes.ErrorDictionary[message];

            return responseFactory.ConflictResponse(message, description);
        }

        mangoDbContext.DiffieHellmanKeyExchangeEntities.Remove(keyExchangeRequest);

        await mangoDbContext.SaveChangesAsync(cancellationToken);

        var result = ResponseBase.SuccessResponse;

        return responseFactory.SuccessResponse(result);
    }
}
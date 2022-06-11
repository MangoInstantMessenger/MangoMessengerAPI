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

namespace MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;

public class CngCreateKeyExchangeRequestCommandHandler : IRequestHandler<CngCreateKeyExchangeRequestCommand,
    Result<CngCreateKeyExchangeResponse>>
{
    private readonly MangoDbContext _dbContext;
    private readonly ResponseFactory<CngCreateKeyExchangeResponse> _responseFactory;

    public CngCreateKeyExchangeRequestCommandHandler(
        MangoDbContext dbContext,
        ResponseFactory<CngCreateKeyExchangeResponse> responseFactory)
    {
        _dbContext = dbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<CngCreateKeyExchangeResponse>> Handle(CngCreateKeyExchangeRequestCommand request,
        CancellationToken cancellationToken)
    {
        var requestedUserExists = await _dbContext.Users.AnyAsync(
            x => x.Id == request.ReceiverId, cancellationToken);

        if (!requestedUserExists)
        {
            const string message = ResponseMessageCodes.UserNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[message];

            return _responseFactory.ConflictResponse(message, details);
        }

        var alreadyRequested = await _dbContext.OpenSslKeyExchangeRequests
            .AnyAsync(x =>
                x.SenderId == request.SenderId &&
                x.ReceiverId == request.ReceiverId &&
                !x.IsConfirmed &&
                x.KeyExchangeType == KeyExchangeType.Cng, cancellationToken);

        if (alreadyRequested)
        {
            const string message = ResponseMessageCodes.KeyExchangeRequestAlreadyExists;
            var details = ResponseMessageCodes.ErrorDictionary[message];

            return _responseFactory.ConflictResponse(message, details);
        }

        await using var target = new MemoryStream();
        await request.SenderPublicKey.CopyToAsync(target, cancellationToken);

        var bytes = target.ToArray();

        var keyExchangeRequest = new OpenSslKeyExchangeRequestEntity()
        {
            SenderId = request.SenderId,
            ReceiverId = request.ReceiverId,
            SenderPublicKey = bytes,
            CreatedAt = DateTime.UtcNow,
            KeyExchangeType = KeyExchangeType.Cng,
            IsConfirmed = false
        };

        _dbContext.OpenSslKeyExchangeRequests.Add(keyExchangeRequest);

        await _dbContext.SaveChangesAsync(cancellationToken);

        var response = new CngCreateKeyExchangeResponse
        {
            Message = ResponseMessageCodes.Success,
            RequestId = keyExchangeRequest.Id,
            Success = true
        };

        return _responseFactory.SuccessResponse(response);
    }
}
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;

public class CngCreateKeyExchangeRequestCommandHandler : IRequestHandler<CngCreateKeyExchangeRequestCommand,
    Result<CngCreateKeyExchangeResponse>>
{
    private readonly MangoPostgresDbContext _postgresDbContext;
    private readonly ResponseFactory<CngCreateKeyExchangeResponse> _responseFactory;

    public CngCreateKeyExchangeRequestCommandHandler(
        MangoPostgresDbContext postgresDbContext,
        ResponseFactory<CngCreateKeyExchangeResponse> responseFactory)
    {
        _postgresDbContext = postgresDbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<CngCreateKeyExchangeResponse>> Handle(CngCreateKeyExchangeRequestCommand request,
        CancellationToken cancellationToken)
    {
        var requestedUserExists = await _postgresDbContext.Users.AnyAsync(
            x => x.Id == request.RequestedUserId, cancellationToken);

        if (!requestedUserExists)
        {
            const string message = ResponseMessageCodes.UserNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[message];

            return _responseFactory.ConflictResponse(message, details);
        }

        var alreadyRequested = await _postgresDbContext.CngKeyExchangeRequests
            .AnyAsync(
                x => x.SenderId == request.UserId && x.UserId == request.RequestedUserId, 
                cancellationToken);

        if (alreadyRequested)
        {
            const string message = ResponseMessageCodes.KeyExchangeRequestAlreadyExists;
            var details = ResponseMessageCodes.ErrorDictionary[message];

            return _responseFactory.ConflictResponse(message, details);
        }

        var keyExchangeRequest = new CngKeyExchangeRequestEntity
        {
            UserId = request.RequestedUserId,
            SenderId = request.UserId,
            SenderPublicKey = request.PublicKey
        };

        _postgresDbContext.CngKeyExchangeRequests.Add(keyExchangeRequest);

        await _postgresDbContext.SaveChangesAsync(cancellationToken);

        var response = new CngCreateKeyExchangeResponse
        {
            Message = ResponseMessageCodes.Success,
            RequestId = keyExchangeRequest.Id,
            Success = true
        };

        return _responseFactory.SuccessResponse(response);
    }
}
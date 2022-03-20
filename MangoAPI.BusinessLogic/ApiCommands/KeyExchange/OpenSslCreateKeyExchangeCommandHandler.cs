using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.BusinessLogic.ApiCommands.KeyExchange;

public class OpenSslCreateKeyExchangeCommandHandler : IRequestHandler<OpenSslCreateKeyExchangeCommand,
    Result<OpenSslCreateKeyExchangeResponse>>
{
    private readonly MangoPostgresDbContext _mangoPostgresDbContext;
    private readonly ResponseFactory<OpenSslCreateKeyExchangeResponse> _responseFactory;

    public OpenSslCreateKeyExchangeCommandHandler(MangoPostgresDbContext mangoPostgresDbContext,
        ResponseFactory<OpenSslCreateKeyExchangeResponse> responseFactory)
    {
        _mangoPostgresDbContext = mangoPostgresDbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<OpenSslCreateKeyExchangeResponse>> Handle(OpenSslCreateKeyExchangeCommand request,
        CancellationToken cancellationToken)
    {
        var requestAlreadyExists = await _mangoPostgresDbContext.OpenSslKeyExchangeRequests
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
            SenderPublicKey = bytes
        };

        _mangoPostgresDbContext.OpenSslKeyExchangeRequests.Add(keyExchangeRequest);

        await _mangoPostgresDbContext.SaveChangesAsync(cancellationToken);

        var response = new OpenSslCreateKeyExchangeResponse
        {
            Message = ResponseMessageCodes.Success,
            RequestId = keyExchangeRequest.Id,
            Success = true
        };

        return _responseFactory.SuccessResponse(response);
    }
}
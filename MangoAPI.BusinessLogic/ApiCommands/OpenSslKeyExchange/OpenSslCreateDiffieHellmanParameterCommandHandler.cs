using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.OpenSslKeyExchange;

public class OpenSslCreateDiffieHellmanParameterCommandHandler : IRequestHandler<OpenSslCreateDiffieHellmanParameterCommand,
    Result<OpenSslCreateDiffieHellmanParameterResponse>>
{
    private readonly MangoDbContext _dbContext;
    private readonly ResponseFactory<OpenSslCreateDiffieHellmanParameterResponse> _responseFactory;

    public OpenSslCreateDiffieHellmanParameterCommandHandler(MangoDbContext dbContext,
        ResponseFactory<OpenSslCreateDiffieHellmanParameterResponse> responseFactory)
    {
        _dbContext = dbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<OpenSslCreateDiffieHellmanParameterResponse>> Handle(OpenSslCreateDiffieHellmanParameterCommand request,
        CancellationToken cancellationToken)
    {
        await using var target = new MemoryStream();
        await request.DiffieHellmanParameter.CopyToAsync(target, cancellationToken);
        var bytes = target.ToArray();
        
        var entity = new OpenSslDhParameterEntity
        {
            OpenSslDhParameter = bytes,
            CreatedBy = request.UserId,
            CreatedAt = DateTime.UtcNow,
        };

        _dbContext.OpenSslDhParameters.Add(entity);

        await _dbContext.SaveChangesAsync(cancellationToken);

        var response = new OpenSslCreateDiffieHellmanParameterResponse
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            ParameterId = entity.Id
        };

        return _responseFactory.SuccessResponse(response);
    }
}
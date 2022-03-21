using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.KeyExchange;

public class OpenSslCreateDiffieHellmanParameterCommandHandler : IRequestHandler<OpenSslCreateDiffieHellmanParameterCommand,
    Result<OpenSslCreateDiffieHellmanParameterResponse>>
{
    private readonly MangoPostgresDbContext _postgresDbContext;
    private readonly ResponseFactory<OpenSslCreateDiffieHellmanParameterResponse> _responseFactory;

    public OpenSslCreateDiffieHellmanParameterCommandHandler(MangoPostgresDbContext postgresDbContext,
        ResponseFactory<OpenSslCreateDiffieHellmanParameterResponse> responseFactory)
    {
        _postgresDbContext = postgresDbContext;
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

        _postgresDbContext.OpenSslDhParameters.Add(entity);

        await _postgresDbContext.SaveChangesAsync(cancellationToken);

        var response = new OpenSslCreateDiffieHellmanParameterResponse
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            ParameterId = entity.Id
        };

        return _responseFactory.SuccessResponse(response);
    }
}
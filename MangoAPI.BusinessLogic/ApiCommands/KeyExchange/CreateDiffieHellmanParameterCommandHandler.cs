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

public class CreateDiffieHellmanParameterCommandHandler : IRequestHandler<CreateDiffieHellmanParameterCommand,
    Result<CreateDiffieHellmanParameterResponse>>
{
    private readonly MangoPostgresDbContext _postgresDbContext;
    private readonly ResponseFactory<CreateDiffieHellmanParameterResponse> _responseFactory;

    public CreateDiffieHellmanParameterCommandHandler(MangoPostgresDbContext postgresDbContext,
        ResponseFactory<CreateDiffieHellmanParameterResponse> responseFactory)
    {
        _postgresDbContext = postgresDbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<CreateDiffieHellmanParameterResponse>> Handle(CreateDiffieHellmanParameterCommand request,
        CancellationToken cancellationToken)
    {
        await using var target = new MemoryStream();
        await request.DiffieHellmanParameter.CopyToAsync(target, cancellationToken);
        var bytes = target.ToArray();
        
        var entity = new DhParameterEntity
        {
            DhParameter = bytes,
            CreatedBy = request.UserId,
            CreatedAt = DateTime.UtcNow,
        };

        _postgresDbContext.DhParameterEntities.Add(entity);

        await _postgresDbContext.SaveChangesAsync(cancellationToken);

        var response = new CreateDiffieHellmanParameterResponse
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            ParameterId = entity.Id
        };

        return _responseFactory.SuccessResponse(response);
    }
}
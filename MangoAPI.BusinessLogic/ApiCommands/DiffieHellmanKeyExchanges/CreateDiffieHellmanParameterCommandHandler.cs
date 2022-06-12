using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Infrastructure.Database;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;

public class CreateDiffieHellmanParameterCommandHandler : IRequestHandler<CreateDiffieHellmanParameterCommand,
    Result<CreateDiffieHellmanParameterResponse>>
{
    private readonly MangoDbContext _dbContext;
    private readonly ResponseFactory<CreateDiffieHellmanParameterResponse> _responseFactory;

    public CreateDiffieHellmanParameterCommandHandler(MangoDbContext dbContext,
        ResponseFactory<CreateDiffieHellmanParameterResponse> responseFactory)
    {
        _dbContext = dbContext;
        _responseFactory = responseFactory;
    }

    public async Task<Result<CreateDiffieHellmanParameterResponse>> Handle(CreateDiffieHellmanParameterCommand request,
        CancellationToken cancellationToken)
    {
        await using var target = new MemoryStream();
        await request.DiffieHellmanParameter.CopyToAsync(target, cancellationToken);
        var bytes = target.ToArray();
        
        var entity = new DiffieHellmanParameterEntity
        {
            OpenSslDhParameter = bytes,
            CreatedBy = request.UserId,
            CreatedAt = DateTime.UtcNow,
        };

        _dbContext.OpenSslDhParameters.Add(entity);

        await _dbContext.SaveChangesAsync(cancellationToken);

        var response = new CreateDiffieHellmanParameterResponse
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            ParameterId = entity.Id
        };

        return _responseFactory.SuccessResponse(response);
    }
}
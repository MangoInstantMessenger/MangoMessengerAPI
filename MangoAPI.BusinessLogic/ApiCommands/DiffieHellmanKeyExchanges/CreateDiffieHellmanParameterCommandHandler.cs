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
    private readonly MangoDbContext dbContext;
    private readonly ResponseFactory<CreateDiffieHellmanParameterResponse> responseFactory;

    public CreateDiffieHellmanParameterCommandHandler(
        MangoDbContext dbContext,
        ResponseFactory<CreateDiffieHellmanParameterResponse> responseFactory)
    {
        this.dbContext = dbContext;
        this.responseFactory = responseFactory;
    }

    public async Task<Result<CreateDiffieHellmanParameterResponse>> Handle(
        CreateDiffieHellmanParameterCommand request,
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

        _ = dbContext.DiffieHellmanParameterEntities.Add(entity);

        _ = await dbContext.SaveChangesAsync(cancellationToken);

        var response = new CreateDiffieHellmanParameterResponse
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            ParameterId = entity.Id,
        };

        return responseFactory.SuccessResponse(response);
    }
}

using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Extensions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Entities;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.SecretChatRequests
{
    public class CreateSecretChatRequestCommandHandler : IRequestHandler<CreateSecretChatRequestCommand,
        Result<ResponseBase>>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly ResponseFactory<ResponseBase> _responseFactory;

        public CreateSecretChatRequestCommandHandler(MangoPostgresDbContext postgresDbContext,
            ResponseFactory<ResponseBase> responseFactory)
        {
            _postgresDbContext = postgresDbContext;
            _responseFactory = responseFactory;
        }

        public async Task<Result<ResponseBase>> Handle(CreateSecretChatRequestCommand request,
            CancellationToken cancellationToken)
        {
            using var alice = new ECDiffieHellmanCng();
            alice.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
            alice.HashAlgorithm = CngAlgorithm.Sha256;

            var publicKeyBytes = alice.PublicKey.ToByteArray();
            var publicKey = publicKeyBytes.BytesAsString();

            var secretChatRequest = new SecretChatRequestEntity
            {
                UserId = request.RequestedUserId,
                SenderId = request.RequestedUserId,
                SenderPublicKey = publicKey
            };

            _postgresDbContext.SecretChatRequests.Add(secretChatRequest);

            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return _responseFactory.SuccessResponse(ResponseBase.SuccessResponse);
        }
    }
}
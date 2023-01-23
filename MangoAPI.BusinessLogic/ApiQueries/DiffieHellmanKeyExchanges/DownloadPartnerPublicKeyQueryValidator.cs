using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;

public class DownloadPartnerPublicKeyQueryValidator : AbstractValidator<DownloadPartnerPublicKeyQuery>
{
    public DownloadPartnerPublicKeyQueryValidator()
    {
        _ = RuleFor(x => x.RequestId).NotEmpty();
        _ = RuleFor(x => x.UserId).NotEmpty();
    }
}
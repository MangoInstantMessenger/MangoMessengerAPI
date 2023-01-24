using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;

public class DownloadPartnerPublicKeyQueryValidator : AbstractValidator<DownloadPartnerPublicKeyQuery>
{
    public DownloadPartnerPublicKeyQueryValidator()
    {
        RuleFor(x => x.RequestId).NotEmpty();
        RuleFor(x => x.UserId).NotEmpty();
    }
}
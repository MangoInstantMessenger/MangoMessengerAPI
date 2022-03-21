using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.KeyExchange;

public class OpenSslDownloadPartnerPublicKeyQueryValidator : AbstractValidator<OpenSslDownloadPartnerPublicKeyQuery>
{
    public OpenSslDownloadPartnerPublicKeyQueryValidator()
    {
        RuleFor(x => x.RequestId).NotEmpty();
        RuleFor(x => x.UserId).NotEmpty();
    }
}
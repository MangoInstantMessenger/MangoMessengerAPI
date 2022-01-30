using System;
using System.ComponentModel;

namespace MangoAPI.BusinessLogic.Models;

public record PublicKey
{
    [DefaultValue("ae9e10a4-0c7e-4911-8450-4139d4a114a7")]
    public Guid PartnerId { get; init; }

    [DefaultValue("RUNLMSAAAAAbc49wfaZ+QF9J2cu1S66bkp0ggCr2tizUA5rxGE1W1")]
    public string PartnerPublicKey { get; init; }

    public override string ToString()
    {
        return $"PartnerId: {PartnerId}\nPublic Key: {PartnerPublicKey}\n";
    }
}
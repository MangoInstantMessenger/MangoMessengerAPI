using System;
using System.ComponentModel;

namespace MangoAPI.BusinessLogic.Models;

public record KeyExchangeRequest
{
    [DefaultValue("81d314c1-913f-4686-827e-ef2a65ccc370")]
    public Guid RequestId { get; init; }

    [DefaultValue("b97f0f95-63ae-4a0e-90a1-10efcef923cf")]
    public Guid SenderId { get; init; }

    [DefaultValue("RUNLMSAAAAAbc49wfaZ+QF9J2cu1S66bkp0ggCr2tizUA5rxGE1W1")]
    public string SenderPublicKey { get; init; }

    public override string ToString()
    {
        return $"RequestId: {RequestId}\nSenderId: {SenderId}\nSender Public Key: {SenderPublicKey}\n";
    }
}
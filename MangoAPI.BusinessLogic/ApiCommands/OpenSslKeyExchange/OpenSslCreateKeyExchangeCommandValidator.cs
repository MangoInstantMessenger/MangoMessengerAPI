﻿using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.OpenSslKeyExchange;

public class OpenSslCreateKeyExchangeCommandValidator : AbstractValidator<OpenSslCreateKeyExchangeCommand>
{
    public OpenSslCreateKeyExchangeCommandValidator()
    {
        RuleFor(x => x.ReceiverId).NotEmpty();
        RuleFor(x => x.SenderId).NotEmpty();
        RuleFor(x => x.SenderPublicKey).NotEmpty();
    }
}
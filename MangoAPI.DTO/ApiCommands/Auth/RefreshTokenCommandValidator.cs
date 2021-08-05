﻿using System;
using FluentValidation;

namespace MangoAPI.DTO.ApiCommands.Auth
{
    public class RefreshTokenCommandValidator : AbstractValidator<RefreshTokenCommand>
    {
        public RefreshTokenCommandValidator()
        {
            RuleFor(x => x.RefreshTokenId)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .Length(2, 300);
            
            RuleFor(x => x.RefreshTokenId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("RefreshTokenCommand: Refresh Token Id cannot be parsed.");
        }
    }
}
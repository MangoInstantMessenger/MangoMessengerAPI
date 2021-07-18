using System;
using MangoAPI.DTO.Responses.Auth;
using MediatR;

namespace MangoAPI.DTO.Commands.Auth
{
    public record VerifyEmailCommand(string Email, string UserId) : IRequest<VerifyEmailResponse>;
}
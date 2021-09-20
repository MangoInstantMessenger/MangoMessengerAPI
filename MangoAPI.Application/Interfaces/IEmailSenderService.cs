using MangoAPI.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.Application.Interfaces
{
    public interface IEmailSenderService
    {
        Task SendVerificationEmailAsync(UserEntity user, CancellationToken cancellationToken);

        Task SendPasswordRestoreRequest(UserEntity user, Guid requestId, CancellationToken cancellationToken);
    }
}
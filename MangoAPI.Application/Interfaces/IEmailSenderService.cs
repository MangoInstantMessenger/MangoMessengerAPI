using MangoAPI.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.Application.Services
{
    public interface IEmailSenderService
    {
        Task SendVerificationEmailAsync(UserEntity user, CancellationToken cancellationToken);
    }
}
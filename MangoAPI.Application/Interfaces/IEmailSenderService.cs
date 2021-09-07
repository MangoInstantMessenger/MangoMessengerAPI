using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Entities;

namespace MangoAPI.Application.Interfaces
{
    public interface IEmailSenderService
    {
        Task SendVerificationEmailAsync(UserEntity user, CancellationToken cancellationToken);
    }
}

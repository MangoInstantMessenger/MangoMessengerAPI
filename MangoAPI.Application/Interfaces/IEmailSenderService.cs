namespace MangoAPI.Application.Interfaces
{
    using System.Threading;
    using System.Threading.Tasks;
    using Domain.Entities;

    public interface IEmailSenderService
    {
        Task SendVerificationEmailAsync(UserEntity user, CancellationToken cancellationToken);
    }
}

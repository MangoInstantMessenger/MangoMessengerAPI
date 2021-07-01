using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Models;

namespace MangoAPI.Application.Services
{
    public interface IChatNotificationService
    {
        Task NotifyChatUsersAsync(int chatId, Message message,CancellationToken cancellationToken);
    }
}
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.DTO.Models;

namespace MangoAPI.Infrastructure.Services
{
    public class ChatNotificationService : IChatNotificationService
    {
        public Task NotifyChatUsersAsync(int chatId, Message message, CancellationToken cancellationToken) =>
            Task.CompletedTask; //ToDo implement notification 
    }
}
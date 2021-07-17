using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace MangoAPI.WebApp.Hubs
{
    public class MessagesHub : Hub
    {
        public async Task OnMessageSendNotify(string groupName, string text)
        {
            await Clients.Group(groupName).SendAsync("onMessageSendNotify", text);
        }
    }
}
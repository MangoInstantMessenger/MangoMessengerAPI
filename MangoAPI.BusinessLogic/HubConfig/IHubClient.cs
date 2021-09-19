using MangoAPI.BusinessLogic.Models;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.HubConfig
{
    public interface IHubClient
    {
        Task BroadcastMessage(Message message);
    }
}

using MangoAPI.BusinessLogic.HubConfig;
using Microsoft.AspNetCore.SignalR;
using Moq;
using System.Threading.Tasks;

namespace MangoAPI.Tests
{
    public static class MockedObjects
    {
        public static IHubContext<ChatHub, IHubClient> GetHubContext()
        {
            var hubMock = new Mock<IHubContext<ChatHub, IHubClient>>();

            hubMock.Setup(x => x.Clients.All.BroadcastMessage()).Returns(Task.CompletedTask);

            return hubMock.Object;
        }
    }
}

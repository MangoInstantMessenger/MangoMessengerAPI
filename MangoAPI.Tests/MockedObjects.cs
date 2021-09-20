using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.BusinessLogic.Models;
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

            hubMock.Setup(x => x.Clients.Group(It.IsAny<string>())
            .BroadcastMessage(It.IsAny<Message>())).Returns(Task.CompletedTask);

            return hubMock.Object;
        }
    }
}
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.BusinessLogic.Models;
using Microsoft.AspNetCore.SignalR;
using Moq;

namespace MangoAPI.Tests
{
    public static class MockedObjects
    {
        public static IHubContext<ChatHub, IHubClient> GetHubContext()
        {
            var hubMock = new Mock<IHubContext<ChatHub, IHubClient>>();

            hubMock
                .Setup(x => x.Clients.Group(It.IsAny<string>())
                    .BroadcastMessageAsync(It.IsAny<Message>()))
                .Returns(Task.CompletedTask);

            hubMock.Setup(x => x.Clients.Group(It.IsAny<string>())
                .UpdateUserChatsAsync(It.IsAny<Chat>())).Returns(Task.CompletedTask);

            hubMock
                .Setup(x => x.Clients.Group(It.IsAny<string>())
                    .NotifyOnMessageDeleteAsync(It.IsAny<MessageDeleteNotification>()))
                .Returns(Task.CompletedTask);

            hubMock
                .Setup(x => x.Clients.Group(It.IsAny<string>())
                    .NotifyOnMessageEditAsync(It.IsAny<MessageEditNotification>()))
                .Returns(Task.CompletedTask);

            return hubMock.Object;
        }
    }
}
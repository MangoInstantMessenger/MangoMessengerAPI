using System;
using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.BusinessLogic.Models;
using Microsoft.AspNetCore.SignalR;
using Moq;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Messages;

namespace MangoAPI.Tests
{
    public static class MockedObjects
    {
        public static IHubContext<ChatHub, IHubClient> GetHubContext()
        {
            var hubMock = new Mock<IHubContext<ChatHub, IHubClient>>();

            hubMock.Setup(x => x.Clients.Group(It.IsAny<string>())
            .BroadcastMessage(It.IsAny<Message>())).Returns(Task.CompletedTask);

            hubMock.Setup(x => x.Clients.Group(It.IsAny<string>())
                .UpdateUserChats(It.IsAny<Chat>())).Returns(Task.CompletedTask);

            hubMock.Setup(x => x.Clients.Group(It.IsAny<string>())
                .NotifyOnMessageDelete(It.IsAny<Guid>())).Returns(Task.CompletedTask);

            hubMock.Setup(x => x.Clients.Group(It.IsAny<string>())
                .NotifyOnMessageEdit(It.IsAny<EditMessageCommand>())).Returns(Task.CompletedTask);

            return hubMock.Object;
        }
    }
}
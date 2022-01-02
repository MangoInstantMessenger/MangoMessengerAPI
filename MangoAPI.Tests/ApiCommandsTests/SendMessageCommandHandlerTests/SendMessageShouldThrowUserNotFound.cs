using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiCommandsTests.SendMessageCommandHandlerTests
{
    [TestFixture]
    public class SendMessageShouldThrowUserNotFound : ITestable<SendMessageCommand, SendMessageResponse>
    {
        public void Seed()
        {
            throw new System.NotImplementedException();
        }

        public IRequestHandler<SendMessageCommand, Result<SendMessageResponse>> CreateHandler()
        {
            throw new System.NotImplementedException();
        }
    }
}
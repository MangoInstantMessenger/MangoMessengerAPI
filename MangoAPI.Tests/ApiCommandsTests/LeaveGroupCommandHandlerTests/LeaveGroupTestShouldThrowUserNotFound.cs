using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.UserChats;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MediatR;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.LeaveGroupCommandHandlerTests
{
    public class LeaveGroupTestShouldThrowUserNotFound : ITestable<LeaveGroupCommand, LeaveGroupResponse>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();
        private readonly Assert<LeaveGroupResponse> _assert = new();

        [Fact]
        public async Task LeaveGroupTestShouldThrow_UserNotFound()
        {
            Seed();
            using var mangoDbFixture = _mangoDbFixture;
            const string expectedMessage = ResponseMessageCodes.UserNotFound;
            string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
            var handler = CreateHandler();

            var result = await handler.Handle(_command, CancellationToken.None);
            
            _assert.Fail(result, expectedMessage, expectedDetails);
        }
        
        public bool Seed()
        {
            return true;
        }

        public IRequestHandler<LeaveGroupCommand, Result<LeaveGroupResponse>> CreateHandler()
        {
            var responseFactory = new ResponseFactory<LeaveGroupResponse>();
            var handler = new LeaveGroupCommandHandler(_mangoDbFixture.Context, responseFactory);
            return handler;
        }

        

        private readonly LeaveGroupCommand _command = new()
        {
            ChatId = SeedDataConstants.ExtremeCodeMainId,
            UserId = SeedDataConstants.RazumovskyId
        };
    }
}
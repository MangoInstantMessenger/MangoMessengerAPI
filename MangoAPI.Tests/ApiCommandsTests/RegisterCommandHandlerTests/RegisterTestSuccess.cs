using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.RegisterCommandHandlerTests
{
    public class RegisterTestSuccess : ITestable<RegisterCommand, ResponseBase>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();
        private readonly Assert<ResponseBase> _assert = new();

        [Fact]
        public async Task RegisterTest_Success()
        {
            Seed();
            var command = new RegisterCommand
            {
                Email = "kolosovp95@gamilc.com",
                DisplayName = "Petro Kolosov",
                Password = "Bm3-`dPRv-/w#3)cw^97",
                TermsAccepted = true
            };
            var handler = CreateHandler();

            var result = await handler.Handle(command, CancellationToken.None);
            
            _assert.Pass(result);
            var user = await _mangoDbFixture.Context.Users.FirstOrDefaultAsync(x => x.Email == command.Email);
            user.DisplayName.Should().Be(command.DisplayName);
        }
        
        public bool Seed()
        {
            return true;
        }

        public IRequestHandler<RegisterCommand, Result<ResponseBase>> CreateHandler()
        {
            var emailSenderServiceMock = MockedObjects.GetEmailSenderServiceMock();
            var userServiceMock = MockedObjects.GetUserServiceMock();
            var responseFactory = new ResponseFactory<ResponseBase>();
            var handler = new RegisterCommandHandler(userServiceMock, _mangoDbFixture.Context, emailSenderServiceMock,
                responseFactory);
            return handler;
        }
    }
}
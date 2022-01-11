using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.PasswordRestoreCommandHandlerTests
{
    public class PasswordRestoreTestShouldThrowUserNotFound : ITestable<PasswordRestoreCommand, ResponseBase>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();
        private readonly Assert<ResponseBase> _assert = new();

        [Fact]
        public async Task PasswordRestoreTestShouldThrow_UserNotFound()
        {
            Seed();
            var handler = CreateHandler();
            const string expectedMessage = ResponseMessageCodes.UserNotFound;
            string expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
            var command = new PasswordRestoreCommand
            {
                RequestId = "9c4ddced-5de5-4388-84fd-39f92a77a977".AsGuid(),
                NewPassword = "Bm3-`dPRv-/w#3)cw^97"
            };

            var result = await handler.Handle(command, CancellationToken.None);
            
            _assert.Fail(result, expectedMessage, expectedDetails);
        }
        
        public bool Seed()
        {
            _mangoDbFixture.Context.PasswordRestoreRequests.Add(new PasswordRestoreRequestEntity
            {
                Id = "9c4ddced-5de5-4388-84fd-39f92a77a977".AsGuid(),
                UserId = SeedDataConstants.RazumovskyId,
                Email = "test@mail.com",
                CreatedAt = DateTime.Now,
                ExpiresAt = DateTime.Now.AddHours(3)
            });

            _mangoDbFixture.Context.SaveChanges();
 
            return true;
        }

        public IRequestHandler<PasswordRestoreCommand, Result<ResponseBase>> CreateHandler()
        {
            var userManagerMock = MockedObjects.GetUserServiceMock("Bm3-`dPRv-/w#3)cw^97");
            var responseFactory = new ResponseFactory<ResponseBase>();
            var handler = new PasswordRestoreCommandHandler(_mangoDbFixture.Context, userManagerMock, responseFactory);
            return handler;
        }
    }
}
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Contacts;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.AddContactCommandHandlerTests
{
    public class AddContactShouldThrowCannotAddSelf : ITestable<AddContactCommand, ResponseBase>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();
        private readonly Assert<ResponseBase> _assert = new();

        [Fact]
        public async Task AddContactCommandHandlerTest_ShouldThrow_CannotAddSelf()
        {
            Seed();
            const string expectedMessage = ResponseMessageCodes.CannotAddSelfToContacts;
            var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
            var handler = CreateHandler();
            var command = new AddContactCommand
            {
                ContactId = SeedDataConstants.RazumovskyId,
                UserId = SeedDataConstants.RazumovskyId
            };

            var result = await handler.Handle(command, CancellationToken.None);

            _assert.Fail(result, expectedMessage, expectedDetails);
        }

        public bool Seed()
        {
            _mangoDbFixture.Context.Users.Add(_user);
            _mangoDbFixture.Context.SaveChanges();

            _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;

            return true;
        }

        public IRequestHandler<AddContactCommand, Result<ResponseBase>> CreateHandler()
        {
            var responseFactory = new ResponseFactory<ResponseBase>();
            var handler = new AddContactCommandHandler(_mangoDbFixture.Context, responseFactory);
            return handler;
        }

        private readonly UserEntity _user = new()
        {
            PhoneNumber = "48743615532",
            DisplayName = "razumovsky r",
            Bio = "11011 y.o Dotnet Developer from $\"{cityName}\"",
            Id = SeedDataConstants.RazumovskyId,
            UserName = "razumovsky_r",
            Email = "kolosovp95@gmail.com",
            NormalizedEmail = "KOLOSOVP94@GMAIL.COM",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            Image = "razumovsky_picture.jpg"
        };
    }
}
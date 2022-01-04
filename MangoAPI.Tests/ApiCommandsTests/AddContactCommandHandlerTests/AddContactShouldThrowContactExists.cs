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
    public class AddContactShouldThrowContactExists : ITestable<AddContactCommand, ResponseBase>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();

        [Fact]
        public async Task AddContactCommandHandlerTest_ShouldThrow_ContactExists()
        {
            Seed();
            const string expectedMessage = ResponseMessageCodes.ContactAlreadyExist;
            var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
            var handler = CreateHandler();
            var command = new AddContactCommand
            {
                UserId = SeedDataConstants.RazumovskyId,
                ContactId = SeedDataConstants.KhachaturId
            };
            await handler.Handle(command, CancellationToken.None);

            var result = await handler.Handle(command, CancellationToken.None);

            result.StatusCode.Should().Be(HttpStatusCode.Conflict);
            result.Response.Should().BeNull();
            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(expectedMessage);
            result.Error.ErrorDetails.Should().Be(expectedDetails);
            result.Error.StatusCode.Should().Be(HttpStatusCode.Conflict);
        }

        public bool Seed()
        {
            _mangoDbFixture.Context.Users.Add(_sender);
            _mangoDbFixture.Context.Users.Add(_receiver);

            _mangoDbFixture.Context.SaveChanges();

            _mangoDbFixture.Context.Entry(_sender).State = EntityState.Detached;
            _mangoDbFixture.Context.Entry(_receiver).State = EntityState.Detached;

            return true;
        }

        public IRequestHandler<AddContactCommand, Result<ResponseBase>> CreateHandler()
        {
            var responseFactory = new ResponseFactory<ResponseBase>();
            var handler = new AddContactCommandHandler(_mangoDbFixture.Context, responseFactory);
            return handler;
        }

        private readonly UserEntity _receiver = new()
        {
            DisplayName = "Khachatur Khachatryan",
            Bio = "13 y. o. | C# pozer, Hearts Of Iron IV noob",
            Id = SeedDataConstants.KhachaturId,
            UserName = "KHACHATUR228",
            Email = "xachulxx@gmail.com",
            NormalizedEmail = "XACHULXX@GMAIL.COM",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            Image = "khachatur_picture.jpg",
        };

        private readonly UserEntity _sender = new()
        {
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
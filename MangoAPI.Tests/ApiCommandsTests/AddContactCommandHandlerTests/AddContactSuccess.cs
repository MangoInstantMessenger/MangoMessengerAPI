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
    public class AddContactSuccess : ITestable<AddContactCommand, ResponseBase>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();

        [Fact]
        public async Task AddContactsCommandHandlerTest_Success()
        {
            Seed();
            const string expectedMessage = ResponseMessageCodes.Success;
            var handler = CreateHandler();
            var command = new AddContactCommand
            {
                UserId = SeedDataConstants.RazumovskyId,
                ContactId = SeedDataConstants.KhachaturId
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.StatusCode.Should().Be(HttpStatusCode.OK);
            result.Error.Should().BeNull();
            result.Response.Message.Should().Be(expectedMessage);
            result.Response.Success.Should().BeTrue();
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
using System;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Documents;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiCommandsTests.UploadDocumentCommandHandlerTests
{
    public class UploadDocumentTestShouldThrowUploadedDocumentsLimitReached10  
        : ITestable<UploadDocumentCommand, UploadDocumentResponse>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();

        [Fact]
        public async Task UploadDocumentTestShouldThrow_UploadedDocumentsLimitReached10()
        {
            Seed();
            const string expectedMessage = ResponseMessageCodes.UploadedDocumentsLimitReached10;
            var expectedDetails = ResponseMessageCodes.ErrorDictionary[expectedMessage];
            var command = new UploadDocumentCommand
            {
                FormFile = new FormFile(null, 0, 120, null, null),
                UserId = SeedDataConstants.RazumovskyId
            };
            var handler = CreateHandler();
            for (int i = 0; i <= 10; i++)
            {
                await handler.Handle(command, CancellationToken.None);
            }
            

            var result = await handler.Handle(command, CancellationToken.None);
            
            result.StatusCode.Should().Be(HttpStatusCode.Conflict);
            result.Response.Should().BeNull();
            result.Error.Success.Should().BeFalse();
            result.Error.ErrorMessage.Should().Be(expectedMessage);
            result.Error.ErrorDetails.Should().Be(expectedDetails);
        }

        public bool Seed()
        {
            _mangoDbFixture.Context.Users.Add(_user);

            _mangoDbFixture.Context.SaveChanges();

            _mangoDbFixture.Context.Entry(_user).State = EntityState.Detached;

            return true;
        }

        public IRequestHandler<UploadDocumentCommand, Result<UploadDocumentResponse>> CreateHandler()
        {
            var blobServiceMock = MockedObjects.GetBlobServiceMock();
            var responseFactory = new ResponseFactory<UploadDocumentResponse>();
            var handler =
                new UploadDocumentCommandHandler(_mangoDbFixture.Context, responseFactory, blobServiceMock);

            return handler;
        }

        private readonly UserEntity _user = new()
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
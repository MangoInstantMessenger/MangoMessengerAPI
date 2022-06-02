using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Documents;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.UploadDocumentCommandHandlerTests;

public class UploadDocumentSuccess : ITestable<UploadDocumentCommand, UploadDocumentResponse>
{
    private readonly MangoDbFixture _mangoDbFixture = new();
    private readonly Assert<UploadDocumentResponse> _assert = new();

    [Fact]
    public async Task UploadDocument_Success()
    {
        Seed();
        var command = new UploadDocumentCommand
        {
            FormFile = new FormFile(null, 0, 120, null, null),
            UserId = SeedDataConstants.RazumovskyId
        };
        var handler = CreateHandler();

        var result = await handler.Handle(command, CancellationToken.None);
            
        _assert.Pass(result);
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
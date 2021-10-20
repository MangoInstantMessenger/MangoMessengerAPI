using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiCommands.Documents;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Internal;
using Moq;
using NUnit.Framework;

namespace MangoAPI.Tests.ApiCommandsTests.Documents
{
    [TestFixture]
    public class UploadDocumentCommandHandlerTest
    {
        [Test]
        public async Task UploadDocumentCommandHandlerTest_Success()
        {
            using var dbContextFixture = new DbContextFixture();
            const string path = "../../../../MangoAPI.Presentation/wwwroot";
            var environment = new Mock<IHostingEnvironment>();
            environment.Object.WebRootPath = path;
            environment.Setup(m => m.WebRootPath)
                .Returns(path);
            var handler = new UploadDocumentCommandHandler(dbContextFixture.PostgresDbContext, environment.Object);
            var command = new UploadDocumentCommand
            {
                FormFile = new FormFile(new MemoryStream(Encoding.UTF8.GetBytes("hello world")),
                    0, 0, "hello world", "helloworld.txt")
            };

            var result = await handler.Handle(command, CancellationToken.None);

            result.Response.Success.Should().BeTrue();
            result.Response.FileName.Should().NotBeNull();
        }
    }
}
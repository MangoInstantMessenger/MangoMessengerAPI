using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.ApiCommandHandlers.Auth;
using MangoAPI.BusinessLogic.ApiCommands.Auth;
using MangoAPI.BusinessLogic.Enums;
using MangoAPI.DataAccess.Database;
using MangoAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Moq;
using NUnit.Framework;

namespace MangoAPI.Tests.CommandHandlerTests
{
    [TestFixture]
    public class RegisterCommandHandlerTests
    {
        [Test]
        public async Task RegisterCommandHandler_200Test()
        {
            // mock all dependencies of handler
            var userManagerMock = new Mock<UserManager<UserEntity>>();
            var dbContextMock = new Mock<MangoPostgresDbContext>();
            var mailSenderMock = new Mock<IEmailSenderService>();

            // setup mocks
            userManagerMock
                .Setup(x => x.FindByIdAsync(It.IsAny<string>()))
                .Returns(() => Task.FromResult<UserEntity>(null));

            dbContextMock
                .Setup(x => x.Users
                    .FirstOrDefaultAsync(It.IsAny<Expression<Func<UserEntity, bool>>>(),
                        It.IsAny<CancellationToken>()))
                .Returns(() => Task.FromResult<UserEntity>(null));

            userManagerMock.Setup(x => x.CreateAsync(It.IsAny<UserEntity>(), It.IsAny<string>()))
                .Returns(() => Task.FromResult(IdentityResult.Success));

            mailSenderMock.Setup(x =>
                    x.SendVerificationEmailAsync(It.IsAny<UserEntity>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);

            dbContextMock.Setup(x => x.SaveChangesAsync(It.IsAny<CancellationToken>()))
                .Returns(() => Task.FromResult(1));

            dbContextMock.Setup(x =>
                    x.UserInformation.AddAsync(It.IsAny<UserInformationEntity>(), It.IsAny<CancellationToken>()))
                .Returns(() => ValueTask.FromResult<EntityEntry<UserInformationEntity>>(null));

            var handler =
                new RegisterCommandHandler(userManagerMock.Object, dbContextMock.Object, mailSenderMock.Object);

            var registerCommand = new RegisterCommand
            {
                PhoneNumber = "12312312312",
                Email = "test@mail.com",
                DisplayName = "Display Name",
                Password = "Pa$$w0rd",
                VerificationMethod = VerificationMethod.Email,
                TermsAccepted = true
            };

            var response = await handler.Handle(registerCommand, CancellationToken.None);

            response.Success.Should().BeTrue();
        }

        [Test]
        public async Task RegisterCommandHandler_400Test()
        {
        }
    }
}
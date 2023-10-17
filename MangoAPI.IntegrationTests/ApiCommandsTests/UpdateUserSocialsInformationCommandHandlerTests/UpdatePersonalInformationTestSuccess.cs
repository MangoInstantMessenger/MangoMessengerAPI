﻿using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.UpdateUserSocialsInformationCommandHandlerTests;

public class UpdatePersonalInformationTestSuccess : IntegrationTestBase
{
    private readonly Assert<UpdatePersonalInformationResponse> assert = new();

    [Fact]
    public async Task UpdatePersonalInformationTestSuccessAsync()
    {
        var user = await RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);
        var command = new UpdatePersonalInformationCommand(
            UserId: user.Response.Tokens.UserId,
            Instagram: "petro.kolosov",
            LinkedIn: "petro.kolosov",
            Facebook: "petro.kolosov",
            Twitter: "petro.kolosov");

        var result = await RequestAsync(command, CancellationToken.None);

        assert.Pass(result);
    }
}

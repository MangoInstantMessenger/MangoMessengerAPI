﻿using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.CreateDiffieHellmanParameterCommandHandlerTests;

public class CreateDiffieHellmanParameterTestSuccess : IntegrationTestBase
{
    private readonly Assert<CreateDiffieHellmanParameterResponse> assert = new();

    [Fact]
    public async Task CreateDiffieHellmanParameterTestSuccessAsync()
    {
        var user = await RequestAsync(
            request: CommandHelper.RegisterPetroCommand(),
            cancellationToken: CancellationToken.None);
        var command = new CreateDiffieHellmanParameterCommand(
            DiffieHellmanParameter: MangoFilesHelper.GetTestImage(),
            UserId: user.Response.Tokens.UserId);

        var response = await RequestAsync(
            request: command, cancellationToken: CancellationToken.None);

        assert.Pass(response);
    }
}

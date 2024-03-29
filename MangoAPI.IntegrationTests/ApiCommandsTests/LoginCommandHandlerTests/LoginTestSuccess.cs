﻿using MangoAPI.BusinessLogic;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.IntegrationTests.Helpers;
using Xunit;

namespace MangoAPI.IntegrationTests.ApiCommandsTests.LoginCommandHandlerTests;

public class LoginTestSuccess : IntegrationTestBase
{
    private readonly Assert<TokensResponse> assert = new();

    [Fact]
    public async Task LoginTestSuccessAsync()
    {
        await MangoModule.RequestAsync(CommandHelper.RegisterPetroCommand(), CancellationToken.None);
        var command = CommandHelper.CreateLoginCommand("PetroKolosov", "Bm3-`dPRv-/w#3)cw^97");

        var result = await MangoModule.RequestAsync(command, CancellationToken.None);

        assert.Pass(result);
    }
}
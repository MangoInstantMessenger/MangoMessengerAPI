using CliWrap;
using MangoAPI.DiffieHellmanLibrary.Extensions;
using MangoAPI.DiffieHellmanLibrary.Helpers;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslCreateDhParametersHandler
{
    public async Task<bool> CreateDhParametersAsync()
    {
        Console.WriteLine("Generating DH parameters... Please wait.");

        var workingDirectory = OpenSslDirectoryHelper.OpenSslDhParametersDirectory;

        var parametersPath = Path.Combine(workingDirectory, FileNameHelper.ParametersFileName);

        workingDirectory.CreateDirectoryIfNotExist();

        var command = Cli.Wrap("openssl").WithArguments(
            new[] {"genpkey", "-genparam", "-algorithm", "DH", "-out", parametersPath});

        await command.ExecuteAsync();

        Console.WriteLine("DH parameters has been generated successfully.");

        return true;
    }
}
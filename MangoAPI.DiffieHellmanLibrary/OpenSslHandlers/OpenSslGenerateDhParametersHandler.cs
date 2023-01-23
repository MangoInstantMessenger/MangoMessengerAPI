using CliWrap;
using MangoAPI.DiffieHellmanLibrary.Extensions;
using MangoAPI.DiffieHellmanLibrary.Helpers;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public static class OpenSslGenerateDhParametersHandler
{
    public static async Task CreateDhParametersAsync()
    {
        Console.WriteLine(@"Generating DH parameters... Please wait.");

        var workingDirectory = OpenSslDirectoryHelper.OpenSslDhParametersDirectory;

        var parametersPath = Path.Combine(workingDirectory, FileNameHelper.ParametersFileName);

        workingDirectory.CreateDirectoryIfNotExist();

        var parametersExist = File.Exists(parametersPath);

        if (!parametersExist)
        {
            var command = Cli.Wrap("openssl").WithArguments(
                new[] { "genpkey", "-genparam", "-algorithm", "DH", "-out", parametersPath });

            _ = await command.ExecuteAsync();
        }

        Console.WriteLine(@"DH parameters has been generated successfully.");
        Console.WriteLine();
    }
}
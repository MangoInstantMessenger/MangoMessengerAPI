using CliWrap;
using MangoAPI.DiffieHellmanLibrary.Helpers;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslCreateDhParametersHandler
{
    public async Task<bool> CreateDhParametersAsync()
    {
        try
        {
            Console.WriteLine("Generating DH parameters... Please wait.");
            var dhParametersWorkingDirectory = DirectoryHelper.OpenSslDhParametersDirectory;

            var dhParametersPath = Path.Combine(dhParametersWorkingDirectory, "dhp.pem");

            if (!Directory.Exists(dhParametersWorkingDirectory))
            {
                Directory.CreateDirectory(dhParametersWorkingDirectory);
            }

            var command = Cli.Wrap("openssl").WithArguments(
                new[] {"genpkey", "-genparam", "-algorithm", "DH", "-out", dhParametersPath});

            await command.ExecuteAsync();

            Console.WriteLine("DH parameters has been generated successfully.");

            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }
}
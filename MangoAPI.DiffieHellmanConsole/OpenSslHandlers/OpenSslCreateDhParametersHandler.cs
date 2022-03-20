using System;
using System.IO;
using System.Threading.Tasks;
using CliWrap;
using MangoAPI.DiffieHellmanConsole.Services;

namespace MangoAPI.DiffieHellmanConsole.OpenSslHandlers;

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

            var cmd = Cli.Wrap("openssl").WithArguments(
                new[] {"genpkey", "-genparam", "-algorithm", "DH", "-out", dhParametersPath});

            await cmd.ExecuteAsync();

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
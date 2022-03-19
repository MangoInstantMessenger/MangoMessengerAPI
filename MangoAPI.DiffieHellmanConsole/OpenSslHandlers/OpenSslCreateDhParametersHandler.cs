using System;
using System.Threading.Tasks;
using CliWrap;

namespace MangoAPI.DiffieHellmanConsole.OpenSslHandlers;

public class OpenSslCreateDhParametersHandler
{
    public async Task<bool> CreateDhParametersAsync()
    {
        try
        {
            Console.WriteLine("Generating DH parameters... Please wait.");

            var cmd = Cli.Wrap("openssl").WithArguments(
                new[] {"genpkey", "-genparam", "-algorithm", "DH", "-out", "dhp.pem"});

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
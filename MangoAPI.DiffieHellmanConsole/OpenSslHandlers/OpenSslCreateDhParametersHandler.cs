using System;
using System.IO;
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

            var path = Path.Combine(AppContext.BaseDirectory, "dhp.pem");

            var cmd = Cli.Wrap("openssl").WithArguments(
                new[] {"genpkey", "-genparam", "-algorithm", "DH", "-out", path});

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
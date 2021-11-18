using System;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.DiffieHellmanConsole.Services;

namespace MangoAPI.DiffieHellmanConsole
{
    public class Program
    {
        private static readonly SessionsService SessionsService = new();

        public static async Task Main(string[] args)
        {
            string email;
            string pass;

            if (args.Length >= 2)
            {
                email = args[0];
                pass = args[1];
            }
            else
            {
                email = "";
                pass = "";
            }

            var loginCommand = new LoginCommand
            {
                EmailOrPhone = email,
                Password = pass
            };

            var loginResponse = await SessionsService.LoginAsync(loginCommand);

            Console.WriteLine("Login operation: ");
            Console.WriteLine(loginResponse.AccessToken);
            Console.WriteLine(loginResponse.RefreshToken);

            var refreshTokenResponse = await SessionsService.RefreshTokenAsync(loginResponse.RefreshToken);

            Console.WriteLine("Refresh token operation: ");
            Console.WriteLine(refreshTokenResponse.AccessToken);
            Console.WriteLine(refreshTokenResponse.RefreshToken);

            Console.ReadKey();
            
            
        }
    }
}
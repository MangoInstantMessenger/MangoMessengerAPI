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
            var email = args[0];
            var pass = args[1];

            var loginCommand = new LoginCommand
            {
                EmailOrPhone = email,
                Password = pass
            };

            var loginResponse = await SessionsService.LoginAsync(loginCommand);

            Console.WriteLine(loginResponse.AccessToken);
            Console.WriteLine(loginResponse.RefreshToken);
            Console.ReadKey();
        }
    }
}
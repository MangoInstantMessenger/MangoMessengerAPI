using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.DiffieHellmanConsole.Services;
using Newtonsoft.Json;

namespace MangoAPI.DiffieHellmanConsole
{
    public static class Program
    {
        private static readonly SessionsService SessionsService = new();

        public static async Task Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Unrecognized command.");
                return;
            }

            var method = args[0];

            switch (method)
            {
                case "login":
                    await Login(args);
                    break;
                default:
                    Console.WriteLine("Unrecognized command.");
                    break;
            }
        }

        private static async Task Login(IReadOnlyList<string> args)
        {
            try
            {
                var email = args[1];
                var pass = args[2];

                var loginCommand = new LoginCommand
                {
                    EmailOrPhone = email,
                    Password = pass
                };

                var loginResponse = await SessionsService.LoginAsync(loginCommand);

                var serialize = JsonConvert.SerializeObject(loginResponse);
                await File.WriteAllTextAsync(Path
                        .Combine(AppContext.BaseDirectory, $"Tokens_{loginResponse.UserId}.txt"), serialize);
                Console.WriteLine("Tokens written to file.");
                Console.WriteLine("Login operation success.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number of parameters.");
            }
            catch (HttpRequestException)
            {
                Console.WriteLine("Invalid credentials.");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.KeyExchange;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.Extensions;
using MangoAPI.BusinessLogic.Responses;
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
                case "key-exchange":
                    await RequestKeyExchange(args);
                    break;
                case "key-exchange-requests":
                    await PrintKeyExchangesList();
                    break;
                case "confirm-key-exchange":
                    await ConfirmKeyExchangeRequest(args);
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

                var serializedTokens = JsonConvert.SerializeObject(loginResponse);
                var path = Path.Combine(AppContext.BaseDirectory, "Tokens.txt");

                await File.WriteAllTextAsync(path, serializedTokens);

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

        private static async Task RequestKeyExchange(IReadOnlyList<string> args)
        {
            try
            {
                var requestedUserId = Guid.Parse(args[1]);
                var tokensPath = Path.Combine(AppContext.BaseDirectory, "Tokens.txt");
                var readTokens = await File.ReadAllTextAsync(tokensPath);
                var tokens = JsonConvert.DeserializeObject<TokensResponse>(readTokens);

                var parameters = new CngKeyCreationParameters
                {
                    ExportPolicy = CngExportPolicies.AllowPlaintextExport
                };

                var keys = CngKey.Create(CngAlgorithm.ECDiffieHellmanP256, null, parameters);

                var ecdh = new ECDiffieHellmanCng(keys);

                var privateKey = ecdh.Key
                    .Export(CngKeyBlobFormat.EccPrivateBlob)
                    .AsBase64String();

                var publicKey = ecdh.PublicKey
                    .ToByteArray()
                    .AsBase64String();

                var keyService = new KeyExchangeService(tokens!.AccessToken);

                var command = new CreateKeyExchangeRequest
                {
                    PublicKey = publicKey,
                    RequestedUserId = requestedUserId
                };

                await keyService.CreateKeyExchangeAsync(command);

                var privateKeyPath = Path.Combine(AppContext.BaseDirectory, $"Keys_{tokens.UserId}",
                    $"PrivateKey_{tokens.UserId}_{requestedUserId}.txt");

                var publicKeyPath = Path.Combine(AppContext.BaseDirectory, $"Keys_{tokens.UserId}",
                    $"PublicKey_{tokens.UserId}_{requestedUserId}.txt");

                if (!Directory.Exists(Path.Combine(AppContext.BaseDirectory, $"Keys_{tokens.UserId}")))
                {
                    Directory
                        .CreateDirectory(Path.Combine(AppContext.BaseDirectory, $"Keys_{tokens.UserId}"));
                }

                var stream = File.Create(privateKeyPath);

                var formatter = new BinaryFormatter();

                Console.WriteLine("Writing private key to file...");
                formatter.Serialize(stream, privateKey);
                stream.Close();

                Console.WriteLine("Writing public key to file ...");
                await File.WriteAllTextAsync(publicKeyPath, publicKey);

                Console.WriteLine("Key exchange request sent successfully.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid parameters count.");
            }
            catch (HttpRequestException)
            {
                Console.WriteLine("Invalid request.");
            }
        }

        private static async Task PrintKeyExchangesList()
        {
            var tokensPath = Path.Combine(AppContext.BaseDirectory, "Tokens.txt");
            var readTokens = await File.ReadAllTextAsync(tokensPath);
            var tokens = JsonConvert.DeserializeObject<TokensResponse>(readTokens);

            var keyService = new KeyExchangeService(tokens!.AccessToken);

            var exchangeList = await keyService.GetKeyExchangesAsync();

            foreach (var request in exchangeList.KeyExchangeRequests)
            {
                Console.WriteLine($"Request Id: {request.RequestId}");
                Console.WriteLine($"Sender Id: {request.SenderId}");
                Console.WriteLine($"Sender public key: {request.SenderPublicKey}");
                Console.WriteLine();
            }
        }

        private static async Task ConfirmKeyExchangeRequest(IReadOnlyList<string> args)
        {
            var requestId = Guid.Parse(args[1]);

            var tokensPath = Path.Combine(AppContext.BaseDirectory, "Tokens.txt");
            var readTokens = await File.ReadAllTextAsync(tokensPath);
            var tokens = JsonConvert.DeserializeObject<TokensResponse>(readTokens);

            var keyService = new KeyExchangeService(tokens!.AccessToken);

            var exchangeRequests = await keyService.GetKeyExchangesAsync();

            var exchangeRequest = exchangeRequests.KeyExchangeRequests
                .FirstOrDefault(x => x.RequestId == requestId);

            if (exchangeRequest == null)
            {
                Console.WriteLine("Key exchange request not found.");
                return;
            }

            var parameters = new CngKeyCreationParameters
            {
                ExportPolicy = CngExportPolicies.AllowPlaintextExport
            };

            var keys = CngKey.Create(CngAlgorithm.ECDiffieHellmanP256, null, parameters);

            var ecdh = new ECDiffieHellmanCng(keys);

            var privateKey = ecdh.Key
                .Export(CngKeyBlobFormat.EccPrivateBlob)
                .AsBase64String();

            var publicKey = ecdh.PublicKey
                .ToByteArray()
                .AsBase64String();

            var requestPublicKey = exchangeRequest.SenderPublicKey.Base64StringAsBytes();

            var commonSecret = ecdh.DeriveKeyMaterial(CngKey.Import(requestPublicKey,
                CngKeyBlobFormat.EccPublicBlob));

            var confirmOrDeclineKeyExchangeRequest = new ConfirmOrDeclineKeyExchangeRequest
            {
                Confirmed = true,
                PublicKey = publicKey,
                RequestId = requestId
            };

            await keyService.ConfirmOrDeclineKeyExchange(confirmOrDeclineKeyExchangeRequest);

            var privateKeyPath = Path.Combine(AppContext.BaseDirectory, $"Keys_{tokens.UserId}",
                $"PrivateKey_{tokens.UserId}_{exchangeRequest.SenderId}.txt");

            var publicKeyPath = Path.Combine(AppContext.BaseDirectory, $"Keys_{tokens.UserId}",
                $"PublicKey_{tokens.UserId}_{exchangeRequest.SenderId}.txt");

            var commonSecretPath = Path.Combine(AppContext.BaseDirectory, $"Keys_{tokens.UserId}",
                $"CommonSecret_{tokens.UserId}_{exchangeRequest.SenderId}.txt");

            if (!Directory.Exists(Path.Combine(AppContext.BaseDirectory, $"Keys_{tokens.UserId}")))
            {
                Directory
                    .CreateDirectory(Path.Combine(AppContext.BaseDirectory, $"Keys_{tokens.UserId}"));
            }

            var stream = File.Create(privateKeyPath);

            var formatter = new BinaryFormatter();

            Console.WriteLine("Writing private key to file...");
            formatter.Serialize(stream, privateKey);
            stream.Close();

            Console.WriteLine("Writing public key to file ...");
            await File.WriteAllTextAsync(publicKeyPath, publicKey);

            stream = File.Create(commonSecretPath);

            Console.WriteLine("Writing common secret to file...");
            formatter.Serialize(stream, commonSecret);
            stream.Close();

            Console.WriteLine("Key exchange request confirmed successfully.");
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.DiffieHellmanConsole.Extensions;
using MangoAPI.DiffieHellmanConsole.Services;

namespace MangoAPI.DiffieHellmanConsole
{
    public static class Program
    {
        private static readonly SessionsService SessionsService = new();
        private static readonly KeyExchangeService KeyExchangeService;
        private static readonly PublicKeysService PublicKeysService;
        private static readonly ChatService ChatService;
        private static readonly TokensResponse Tokens;

        static Program()
        {
            try
            {
                Tokens = TokensService.GetTokensAsync().GetAwaiter().GetResult();
                KeyExchangeService = new KeyExchangeService(Tokens.AccessToken);
                PublicKeysService = new PublicKeysService(Tokens.AccessToken);
                ChatService = new ChatService(Tokens.AccessToken);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Tokens file does not exist for current user.");
            }
        }

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
                case "refresh-token":
                    await RefreshTokenAsync();
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
                case "print-public-keys":
                    await PrintPublicKeys();
                    break;
                case "create-common-secret":
                    await CreateCommonSecret(args);
                    break;
                case "chat-list":
                    await GetCurrentUserChats();
                    break;
                default:
                    Console.WriteLine("Unrecognized command.");
                    break;
            }
        }

        private static async Task Login(IReadOnlyList<string> args)
        {
            Console.WriteLine("Attempting to login ...");
            var loginResponse = await SessionsService.LoginAsync(args);

            Console.WriteLine("Writing tokens to file ...");
            await TokensService.WriteTokensAsync(loginResponse);

            Console.WriteLine("Login operation success.\n");
        }

        private static async Task RefreshTokenAsync()
        {
            if (Tokens is null)
            {
                //Console.WriteLine("User is not authorized. Please login.");
                return;
            }
            
            var refreshToken = Tokens.RefreshToken;

            Console.WriteLine("Refreshing tokens ...");
            var refreshTokenResponse = await SessionsService.RefreshTokenAsync(refreshToken);
            
            Console.WriteLine("Writing tokens to file ...");
            await TokensService.WriteTokensAsync(refreshTokenResponse);

            Console.WriteLine("Refresh token operation was succeeded. \n");
        }

        private static async Task RequestKeyExchange(IReadOnlyList<string> args)
        {
            var requestedUserId = Guid.Parse(args[1]);

            EcdhService.GenerateEcdhKeysPair(out var privateKeyBase64, out var publicKeyBase64);

            var response = await KeyExchangeService.CreateKeyExchangeRequestAsync(requestedUserId, publicKeyBase64);

            Console.WriteLine($"Key exchange request with an ID {response.RequestId} created successfully.");

            var keysFolderPath = Path.Combine(AppContext.BaseDirectory, $"Keys_{Tokens.UserId}");
            var privateKeyPath = Path.Combine(keysFolderPath, $"PrivateKey_{Tokens.UserId}_{requestedUserId}.txt");
            var publicKeyPath = Path.Combine(keysFolderPath, $"PublicKey_{Tokens.UserId}_{requestedUserId}.txt");

            if (!Directory.Exists(keysFolderPath))
            {
                Directory.CreateDirectory(keysFolderPath);
            }

            Console.WriteLine("Writing private key to file...");
            await File.WriteAllTextAsync(privateKeyPath, privateKeyBase64);

            Console.WriteLine("Writing public key to file ...");
            await File.WriteAllTextAsync(publicKeyPath, publicKeyBase64);

            Console.WriteLine("Key exchange request sent successfully.\n");
        }

        private static async Task PrintKeyExchangesList()
        {
            var response = await KeyExchangeService.GetKeyExchangesAsync();
            response.KeyExchangeRequests.ForEach(Console.WriteLine);
        }

        private static async Task ConfirmKeyExchangeRequest(IReadOnlyList<string> args)
        {
            var requestId = Guid.Parse(args[1]);

            var exchangeRequest = (await KeyExchangeService.GetKeyExchangesAsync())
                .KeyExchangeRequests
                .FirstOrDefault(x => x.RequestId == requestId);

            if (exchangeRequest == null)
            {
                Console.WriteLine("Key exchange request not found.");
                return;
            }

            var ecDiffieHellmanCng =
                EcdhService.GenerateEcdhKeysPair(out var privateKeyBase64, out var publicKeyBase64);

            var requestPublicKeyBytes = exchangeRequest.SenderPublicKey.Base64StringAsBytes();
            var requestPublicKey = CngKey.Import(requestPublicKeyBytes, CngKeyBlobFormat.EccPublicBlob);

            var commonSecret = ecDiffieHellmanCng.DeriveKeyMaterial(requestPublicKey).AsBase64String();

            await KeyExchangeService.ConfirmOrDeclineKeyExchange(requestId, publicKeyBase64);

            var keysFolderPath = Path.Combine(AppContext.BaseDirectory, $"Keys_{Tokens.UserId}");

            var privateKeyPath =
                Path.Combine(keysFolderPath, $"PrivateKey_{Tokens.UserId}_{exchangeRequest.SenderId}.txt");

            var publicKeyPath =
                Path.Combine(keysFolderPath, $"PublicKey_{Tokens.UserId}_{exchangeRequest.SenderId}.txt");

            var commonSecretPath =
                Path.Combine(keysFolderPath, $"CommonSecret_{Tokens.UserId}_{exchangeRequest.SenderId}.txt");

            if (!Directory.Exists(keysFolderPath))
            {
                Directory.CreateDirectory(keysFolderPath);
            }

            Console.WriteLine("Writing private key to file...");
            await File.WriteAllTextAsync(privateKeyPath, privateKeyBase64);

            Console.WriteLine("Writing public key to file ...");
            await File.WriteAllTextAsync(publicKeyPath, publicKeyBase64);

            Console.WriteLine("Writing common secret to file...");
            await File.WriteAllTextAsync(commonSecretPath, commonSecret);

            Console.WriteLine("Key exchange request confirmed successfully.\n");
        }

        private static async Task PrintPublicKeys()
        {
            var response = await PublicKeysService.GetPublicKeys();
            response.PublicKeys.ForEach(Console.WriteLine);
        }

        private static async Task CreateCommonSecret(IReadOnlyList<string> args)
        {
            var partnerId = Guid.Parse(args[1]);

            var response = await PublicKeysService.GetPublicKeys();

            var partnerPublicKeyBytes = response.PublicKeys
                .FirstOrDefault(x => x.PartnerId == partnerId)?
                .PartnerPublicKey.Base64StringAsBytes();

            var privateKeyPath = Path.Combine(AppContext.BaseDirectory, $"Keys_{Tokens.UserId}",
                $"PrivateKey_{Tokens.UserId}_{partnerId}.txt");

            var commonSecretPath = Path.Combine(AppContext.BaseDirectory, $"Keys_{Tokens.UserId}",
                $"CommonSecret_{Tokens.UserId}_{partnerId}.txt");

            var privateKeyBytes = (await File.ReadAllTextAsync(privateKeyPath)).Base64StringAsBytes();

            var privateKey = CngKey.Import(privateKeyBytes, CngKeyBlobFormat.EccPrivateBlob);
            var ecDiffieHellmanCng = new ECDiffieHellmanCng(privateKey);

            var partnerPublicKey = CngKey.Import(partnerPublicKeyBytes!, CngKeyBlobFormat.EccPublicBlob);
            var commonSecretBase64 = ecDiffieHellmanCng.DeriveKeyMaterial(partnerPublicKey).AsBase64String();

            Console.WriteLine("Writing common secret to file...");
            await File.WriteAllTextAsync(commonSecretPath, commonSecretBase64);

            Console.WriteLine("Common secret generated successfully.\n");
        }
        
        private static async Task GetCurrentUserChats()
        {
            var response = await ChatService.GetCurrentUserChatsAsync();
            response.Chats.ForEach(Console.WriteLine);
        }
    }
}
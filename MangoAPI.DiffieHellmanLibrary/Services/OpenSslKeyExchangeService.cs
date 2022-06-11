using System.Security.Cryptography;
using CliWrap;
using MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.DiffieHellmanLibrary.Constants;
using MangoAPI.DiffieHellmanLibrary.Extensions;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using Newtonsoft.Json;

namespace MangoAPI.DiffieHellmanLibrary.Services;

public class OpenSslKeyExchangeService : BaseHandler
{
    public OpenSslKeyExchangeService(HttpClient httpClient, TokensService tokensService) : base(httpClient,
        tokensService)
    {
    }

    public async Task<bool> OpenSslUploadDhParametersAsync()
    {
        var parametersPath = Path.Combine(
            OpenSslDirectoryHelper.OpenSslDhParametersDirectory,
            FileNameHelper.ParametersFileName);

        await using var stream = File.OpenRead(parametersPath);

        var uri = new Uri(OpenSslRoutes.OpenSslParameters, UriKind.Absolute);

        using var request = new HttpRequestMessage(HttpMethod.Post, uri);

        using var content = new MultipartFormDataContent
        {
            { new StreamContent(stream), "file", "dhp.pem" }
        };

        request.Content = content;

        var httpResponseMessage = await HttpClient.SendAsync(request);

        httpResponseMessage.EnsureSuccessStatusCode();

        return true;
    }

    public async Task<bool> OpenSslDownloadDhParametersAsync()
    {
        var uri = new Uri(uriString: OpenSslRoutes.OpenSslParameters, UriKind.Absolute);

        var workingDirectory = OpenSslDirectoryHelper.OpenSslDhParametersDirectory;

        var response = await HttpClient.GetAsync(uri);

        response.EnsureSuccessStatusCode();

        await using var stream = await response.Content.ReadAsStreamAsync();

        var filePath = Path.Combine(workingDirectory, FileNameHelper.DownloadedParametersFileName);

        workingDirectory.CreateDirectoryIfNotExist();

        var fileInfo = new FileInfo(filePath);

        await using var fileStream = fileInfo.OpenWrite();

        await stream.CopyToAsync(fileStream);

        return true;
    }

    public async Task OpenSslGeneratePrivateKeyAsync(Guid receiverId)
    {
        var tokensResponse = await TokensService.GetTokensAsync();

        var senderId = tokensResponse.Tokens.UserId;

        var privateKeyFileName = FileNameHelper.GeneratePrivateKeyFileName(senderId, receiverId);

        var workingDirectory = OpenSslDirectoryHelper.OpenSslPrivateKeysDirectory;

        var privateKeyPath = Path.Combine(workingDirectory, privateKeyFileName);

        workingDirectory.CreateDirectoryIfNotExist();

        var dhParametersPath = Path.Combine(
            OpenSslDirectoryHelper.OpenSslDhParametersDirectory,
            FileNameHelper.DownloadedParametersFileName);

        var command = Cli.Wrap("openssl").WithArguments(
            new[] { "genpkey", "-paramfile", dhParametersPath, "-out", privateKeyPath });

        await command.ExecuteAsync();
    }

    public async Task<bool> OpenSslGeneratePublicKeyAsync(Guid receiverId)
    {
        var tokensResponse = await TokensService.GetTokensAsync();

        var senderId = tokensResponse.Tokens.UserId;

        var publicKeyFileName = FileNameHelper.GeneratePublicKeyFileName(senderId, receiverId);

        var privateKeyFileName = FileNameHelper.GeneratePrivateKeyFileName(senderId, receiverId);

        var workingDirectory = OpenSslDirectoryHelper.OpenSslPublicKeysDirectory;

        var publicKeyPath = Path.Combine(workingDirectory, publicKeyFileName);

        var privateKeyPath = Path.Combine(OpenSslDirectoryHelper.OpenSslPrivateKeysDirectory, privateKeyFileName);

        workingDirectory.CreateDirectoryIfNotExist();

        var command = Cli.Wrap("openssl").WithArguments(
            new[] { "pkey", "-in", privateKeyPath, "-pubout", "-out", publicKeyPath });

        await command.ExecuteAsync();

        return true;
    }

    public async Task<bool> OpenSslCreateKeyExchangeAsync(Guid receiverId)
    {
        var tokensResponse = await TokensService.GetTokensAsync();

        var senderId = tokensResponse.Tokens.UserId;

        var workingDirectory = OpenSslDirectoryHelper.OpenSslPublicKeysDirectory;

        var publicKeyFileName = FileNameHelper.GeneratePublicKeyFileName(senderId, receiverId);

        var publicKeyPath = Path.Combine(workingDirectory, publicKeyFileName);

        var route = $"{OpenSslRoutes.OpenSslKeyExchangeRequests}/{receiverId}";

        var uri = new Uri(route, UriKind.Absolute);

        using var request = new HttpRequestMessage(HttpMethod.Post, uri);

        await using var stream = File.OpenRead(publicKeyPath);

        using var content = new MultipartFormDataContent
        {
            { new StreamContent(stream), "senderPublicKey", publicKeyFileName }
        };

        request.Content = content;

        var httpResponseMessage = await HttpClient.SendAsync(request);

        httpResponseMessage.EnsureSuccessStatusCode();

        return true;
    }

    public async Task<List<OpenSslKeyExchangeRequest>> OpensslGetKeyExchangesAsync()
    {
        var uri = new Uri(OpenSslRoutes.OpenSslKeyExchangeRequests, UriKind.Absolute);

        var response = await HttpClient.GetAsync(uri);

        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        var deserialized =
            JsonConvert.DeserializeObject<OpenSslGetKeyExchangeRequestsResponse>(responseBody) ??
            throw new InvalidOperationException("Cannot deserialize list of key exchange requests.");

        var requests = deserialized.OpenSslKeyExchangeRequests;

        return requests;
    }

    public async Task<bool> OpensslConfirmKeyExchange(Guid senderId)
    {
        var allRequests = await OpensslGetKeyExchangesAsync();

        var tokensResponse = await TokensService.GetTokensAsync();
        var currentUserId = tokensResponse.Tokens.UserId;

        var keyExchangeRequest = allRequests.FirstOrDefault(x =>
            x.SenderId == senderId && x.ReceiverId == currentUserId);

        if (keyExchangeRequest == null)
        {
            throw new InvalidOperationException();
        }

        var route = $"{OpenSslRoutes.OpenSslKeyExchangeRequests}/{keyExchangeRequest.RequestId}";

        var uri = new Uri(route, UriKind.Absolute);

        var workingDirectory = OpenSslDirectoryHelper.OpenSslPublicKeysDirectory;

        var publicKeyFileName = FileNameHelper.GeneratePublicKeyFileName(currentUserId, senderId);

        var publicKeyPath = Path.Combine(workingDirectory, publicKeyFileName);

        using var request = new HttpRequestMessage(HttpMethod.Put, uri);

        await using var stream = File.OpenRead(publicKeyPath);

        using var content = new MultipartFormDataContent
        {
            { new StreamContent(stream), "receiverPublicKey", publicKeyFileName }
        };

        request.Content = content;

        var httpResponseMessage = await HttpClient.SendAsync(request);

        httpResponseMessage.EnsureSuccessStatusCode();

        return true;
    }

    public async Task<bool> OpensslCreateCommonSecretAsync(Actor actor, Guid partnerId)
    {
        var allKeyExchanges = await OpensslGetKeyExchangesAsync();

        var tokensResponse = await TokensService.GetTokensAsync();
        var tokens = tokensResponse.Tokens;
        var currentUserId = tokens.UserId;

        OpenSslKeyExchangeRequest keyExchangeRequest;

        if (actor == Actor.Receiver)
        {
            keyExchangeRequest = allKeyExchanges.FirstOrDefault(x =>
                x.SenderId == partnerId && x.ReceiverId == currentUserId);
        }
        else
        {
            keyExchangeRequest = allKeyExchanges.FirstOrDefault(x =>
                x.SenderId == currentUserId && x.ReceiverId == partnerId);
        }

        if (keyExchangeRequest == null)
        {
            throw new InvalidOperationException();
        }

        var requestId = keyExchangeRequest.RequestId;

        var receiverId = keyExchangeRequest.Actor == Actor.Receiver
            ? keyExchangeRequest.SenderId
            : keyExchangeRequest.ReceiverId;

        var publicKeyDirectory = OpenSslDirectoryHelper.OpenSslPublicKeysDirectory;
        var privateKeyDirectory = OpenSslDirectoryHelper.OpenSslPrivateKeysDirectory;
        var commonSecretDirectory = OpenSslDirectoryHelper.OpenSslCommonSecretsDirectory;

        var publicKeyFileName = FileNameHelper.GeneratePublicKeyFileName(currentUserId, requestId);
        var privateKeyFileName = FileNameHelper.GeneratePrivateKeyFileName(currentUserId, receiverId);
        var commonSecretFileName = FileNameHelper.GenerateCommonSecretFileName(currentUserId, receiverId);

        commonSecretDirectory.CreateDirectoryIfNotExist();

        var publicKeyPath = Path.Combine(publicKeyDirectory, publicKeyFileName);
        var privateKeyPath = Path.Combine(privateKeyDirectory, privateKeyFileName);
        var commonSecretPath = Path.Combine(commonSecretDirectory, commonSecretFileName);

        var command = Cli.Wrap("openssl").WithArguments(
            new[]
            {
                "pkeyutl", "-derive", "-inkey", privateKeyPath, "-peerkey", publicKeyPath, "-out", commonSecretPath
            });

        await command.ExecuteAsync();

        return true;
    }

    public async Task<bool> OpensslDownloadPublicKeyAsync(Actor actor, Guid userId)
    {
        var tokensResponse = await TokensService.GetTokensAsync();
        var currentUserId = tokensResponse.Tokens.UserId;

        var allRequests = await OpensslGetKeyExchangesAsync();

        OpenSslKeyExchangeRequest keyExchangeRequest;

        if (actor == Actor.Receiver)
        {
            keyExchangeRequest = allRequests.FirstOrDefault(request =>
                request.SenderId == userId && request.ReceiverId == currentUserId);
        }
        else
        {
            keyExchangeRequest = allRequests.FirstOrDefault(request =>
                request.ReceiverId == userId && request.SenderId == currentUserId);
        }

        if (keyExchangeRequest == null)
        {
            throw new InvalidOperationException();
        }

        var address = $"{OpenSslRoutes.OpenSslPublicKeys}/{keyExchangeRequest.RequestId}";
        var uri = new Uri(address, UriKind.Absolute);

        var response = await HttpClient.GetAsync(uri);
        response.EnsureSuccessStatusCode();

        await using var stream = await response.Content.ReadAsStreamAsync();

        var workingDirectory = OpenSslDirectoryHelper.OpenSslPublicKeysDirectory;

        var publicKeyFileName = FileNameHelper.GeneratePublicKeyFileName(
            currentUserId,
            keyExchangeRequest.RequestId);

        var filePath = Path.Combine(workingDirectory, publicKeyFileName);

        workingDirectory.CreateDirectoryIfNotExist();

        var fileInfo = new FileInfo(filePath);

        await using var fileStream = fileInfo.OpenWrite();

        await stream.CopyToAsync(fileStream);

        return true;
    }

    public async Task<bool> OpenSslDeclineKeyExchangeAsync(Guid requestId)
    {
        var address = $"{OpenSslRoutes.OpenSslKeyExchangeRequests}/{requestId}";
        var uri = new Uri(address, UriKind.Absolute);

        var httpResponseMessage = await HttpClient.DeleteAsync(uri);
        httpResponseMessage.EnsureSuccessStatusCode();

        return true;
    }

    public async Task<OpenSslKeyExchangeRequest> OpenSslGetKeyExchangeByIdAsync(Guid requestId)
    {
        var address = $"{OpenSslRoutes.OpenSslKeyExchangeRequests}/{requestId}";
        var uri = new Uri(address, UriKind.Absolute);

        var response = await HttpClient.GetAsync(uri);
        response.EnsureSuccessStatusCode();

        var jsonAsString = await response.Content.ReadAsStringAsync();

        var deserializeObject =
            JsonConvert.DeserializeObject<OpenSslGetKeyExchangeRequestByIdResponse>(jsonAsString)
            ?? throw new InvalidOperationException();

        var exchangeRequest = deserializeObject.KeyExchangeRequest;

        return exchangeRequest;
    }

    public async Task<(string senderHash, string receiverHash)> ValidateCommonSecretAsync(Guid senderId,
        Guid receiverId)
    {
        var commonSecretDirectory = OpenSslDirectoryHelper.OpenSslCommonSecretsDirectory;
        var senderCommonSecretFileName = FileNameHelper.GenerateCommonSecretFileName(senderId, receiverId);
        var receiverCommonSecretFileName = FileNameHelper.GenerateCommonSecretFileName(receiverId, senderId);


        var senderPath = Path.Combine(commonSecretDirectory, senderCommonSecretFileName);
        var receiverPath = Path.Combine(commonSecretDirectory, receiverCommonSecretFileName);

        var key = RandomNumberGenerator.GetBytes(128);

        var senderHash = await ComputeHashAsync(key, senderPath);
        var receiverHash = await ComputeHashAsync(key, receiverPath);

        return (senderHash, receiverHash);
    }

    private static async Task<string> ComputeHashAsync(byte[] key, string path)
    {
        using var md5 = new HMACSHA512(key);
        await using var senderStream = File.OpenRead(path);
        var hashBytes = await md5.ComputeHashAsync(senderStream);
        var hashAsString = Convert.ToBase64String(hashBytes);

        return hashAsString;
    }
}
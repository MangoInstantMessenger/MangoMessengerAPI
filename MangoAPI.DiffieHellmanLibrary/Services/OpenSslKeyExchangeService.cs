using System.Net.Http.Headers;
using CliWrap;
using MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.DiffieHellmanLibrary.Consts;
using MangoAPI.DiffieHellmanLibrary.Extensions;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using MangoAPI.Domain.Constants;
using Newtonsoft.Json;

namespace MangoAPI.DiffieHellmanLibrary.Services;

public class OpenSslKeyExchangeService
{
    private readonly HttpClient _httpClient;
    private readonly TokensService _tokensService;

    public OpenSslKeyExchangeService(HttpClient httpClient, TokensService tokensService)
    {
        _httpClient = httpClient;
        _tokensService = tokensService;

        var tokensResponse = _tokensService.GetTokensAsync().GetAwaiter().GetResult();

        if (tokensResponse == null)
        {
            const string error = ResponseMessageCodes.TokensNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[error];

            throw new InvalidOperationException($"{error}. {details}, {nameof(tokensResponse)}");
        }

        var accessToken = tokensResponse.Tokens.AccessToken;

        _httpClient.DefaultRequestHeaders.Authorization
            = new AuthenticationHeaderValue("Bearer", accessToken);
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
            {new StreamContent(stream), "file", "dhp.pem"}
        };

        request.Content = content;

        var httpResponseMessage = await _httpClient.SendAsync(request);

        httpResponseMessage.EnsureSuccessStatusCode();

        return true;
    }

    public async Task<bool> OpenSslDownloadDhParametersAsync()
    {
        var uri = new Uri(uriString: OpenSslRoutes.OpenSslParameters, UriKind.Absolute);

        var workingDirectory = OpenSslDirectoryHelper.OpenSslDhParametersDirectory;

        var response = await _httpClient.GetAsync(uri);

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
        var tokensResponse = await _tokensService.GetTokensAsync();

        var senderId = tokensResponse.Tokens.UserId;

        var privateKeyFileName = FileNameHelper.GeneratePrivateKeyFileName(senderId, receiverId);

        var workingDirectory = OpenSslDirectoryHelper.OpenSslPrivateKeysDirectory;

        var privateKeyPath = Path.Combine(workingDirectory, privateKeyFileName);

        workingDirectory.CreateDirectoryIfNotExist();

        var dhParametersPath = Path.Combine(
            OpenSslDirectoryHelper.OpenSslDhParametersDirectory,
            FileNameHelper.DownloadedParametersFileName);

        var command = Cli.Wrap("openssl").WithArguments(
            new[] {"genpkey", "-paramfile", dhParametersPath, "-out", privateKeyPath});

        await command.ExecuteAsync();
    }

    public async Task<bool> OpenSslGeneratePublicKeyAsync(Guid receiverId)
    {
        var tokensResponse = await _tokensService.GetTokensAsync();

        var senderId = tokensResponse.Tokens.UserId;

        var publicKeyFileName = FileNameHelper.GeneratePublicKeyFileName(senderId, receiverId);

        var privateKeyFileName = FileNameHelper.GeneratePrivateKeyFileName(senderId, receiverId);

        var workingDirectory = OpenSslDirectoryHelper.OpenSslPublicKeysDirectory;

        var publicKeyPath = Path.Combine(workingDirectory, publicKeyFileName);

        var privateKeyPath = Path.Combine(OpenSslDirectoryHelper.OpenSslPrivateKeysDirectory, privateKeyFileName);

        workingDirectory.CreateDirectoryIfNotExist();

        var command = Cli.Wrap("openssl").WithArguments(
            new[] {"pkey", "-in", privateKeyPath, "-pubout", "-out", publicKeyPath});

        await command.ExecuteAsync();

        return true;
    }

    public async Task<bool> OpenSslCreateKeyExchangeAsync(Guid receiverId)
    {
        var tokensResponse = await _tokensService.GetTokensAsync();

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
            {new StreamContent(stream), "senderPublicKey", publicKeyFileName}
        };

        request.Content = content;

        var httpResponseMessage = await _httpClient.SendAsync(request);

        httpResponseMessage.EnsureSuccessStatusCode();

        return true;
    }

    public async Task<List<OpenSslKeyExchangeRequest>> OpensslGetKeyExchangesAsync()
    {
        var uri = new Uri(OpenSslRoutes.OpenSslKeyExchangeRequests, UriKind.Absolute);

        var response = await _httpClient.GetAsync(uri);

        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        var deserialized =
            JsonConvert.DeserializeObject<OpenSslGetKeyExchangeRequestsResponse>(responseBody) ??
            throw new InvalidOperationException("Cannot deserialize list of key exchange requests.");

        var requests = deserialized.OpenSslKeyExchangeRequests;

        return requests;
    }

    public async Task<bool> OpensslConfirmKeyExchange(Guid requestId)
    {
        var exchangeRequests = await OpensslGetKeyExchangesAsync();

        var keyExchangeRequest = exchangeRequests.First(request => request.RequestId == requestId);

        var route = $"{OpenSslRoutes.OpenSslKeyExchangeRequests}/{requestId}";

        var uri = new Uri(route, UriKind.Absolute);

        var tokensResponse = await _tokensService.GetTokensAsync();

        var userId = tokensResponse.Tokens.UserId;

        var workingDirectory = OpenSslDirectoryHelper.OpenSslPublicKeysDirectory;

        var partnerId = keyExchangeRequest.Actor == Actor.Sender
            ? keyExchangeRequest.ReceiverId
            : keyExchangeRequest.SenderId;

        var publicKeyFileName = FileNameHelper.GeneratePublicKeyFileName(userId, partnerId);

        var publicKeyPath = Path.Combine(workingDirectory, publicKeyFileName);

        using var request = new HttpRequestMessage(HttpMethod.Put, uri);

        await using var stream = File.OpenRead(publicKeyPath);

        using var content = new MultipartFormDataContent
        {
            {new StreamContent(stream), "receiverPublicKey", publicKeyFileName}
        };

        request.Content = content;

        var httpResponseMessage = await _httpClient.SendAsync(request);

        httpResponseMessage.EnsureSuccessStatusCode();

        return true;
    }

    public async Task<bool> OpensslCreateCommonSecretAsync(Guid requestId)
    {
        var requests = await OpensslGetKeyExchangesAsync();

        var currentRequest = requests.First(x => x.RequestId == requestId);

        var tokensResponse = await _tokensService.GetTokensAsync();
        var tokens = tokensResponse.Tokens;
        var userId = tokens.UserId;

        var receiverId = currentRequest.Actor == Actor.Receiver
            ? currentRequest.SenderId
            : currentRequest.ReceiverId;

        var publicKeyDirectory = OpenSslDirectoryHelper.OpenSslPublicKeysDirectory;
        var privateKeyDirectory = OpenSslDirectoryHelper.OpenSslPrivateKeysDirectory;
        var commonSecretDirectory = OpenSslDirectoryHelper.OpenSslCommonSecretsDirectory;

        var publicKeyFileName = FileNameHelper.GeneratePublicKeyFileName(userId, requestId);
        var privateKeyFileName = FileNameHelper.GeneratePrivateKeyFileName(userId, receiverId);
        var commonSecretFileName = FileNameHelper.GenerateCommonSecretFileName(userId, requestId);

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

    public async Task<bool> OpensslDownloadPublicKeyAsync(Guid requestId)
    {
        var tokensResponse = await _tokensService.GetTokensAsync();
        var userId = tokensResponse.Tokens.UserId;

        var address = $"{OpenSslRoutes.OpenSslPublicKeys}/{requestId}";
        var uri = new Uri(address, UriKind.Absolute);

        var response = await _httpClient.GetAsync(uri);
        response.EnsureSuccessStatusCode();

        await using var stream = await response.Content.ReadAsStreamAsync();

        var workingDirectory = OpenSslDirectoryHelper.OpenSslPublicKeysDirectory;
        var publicKeyFileName = FileNameHelper.GeneratePublicKeyFileName(userId, requestId);
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

        var httpResponseMessage = await _httpClient.DeleteAsync(uri);
        httpResponseMessage.EnsureSuccessStatusCode();

        return true;
    }

    public async Task<OpenSslKeyExchangeRequest> OpenSslGetKeyExchangeByIdAsync(Guid requestId)
    {
        var address = $"{OpenSslRoutes.OpenSslKeyExchangeRequests}/{requestId}";
        var uri = new Uri(address, UriKind.Absolute);

        var response = await _httpClient.GetAsync(uri);
        response.EnsureSuccessStatusCode();

        var jsonAsString = await response.Content.ReadAsStringAsync();

        var deserializeObject =
            JsonConvert.DeserializeObject<OpenSslGetKeyExchangeRequestByIdResponse>(jsonAsString)
            ?? throw new InvalidOperationException();

        var result = deserializeObject.KeyExchangeRequest;

        return result;
    }
}
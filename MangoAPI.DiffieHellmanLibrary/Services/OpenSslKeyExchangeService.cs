using System.Net.Http.Headers;
using CliWrap;
using MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.DiffieHellmanLibrary.Consts;
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
        var dhParametersPath = Path.Combine(DirectoryHelper.OpenSslDhParametersDirectory, "dhp.pem");

        await using var stream = File.OpenRead(dhParametersPath);

        var uri = new Uri(Routes.OpenSslParameters, UriKind.Absolute);

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
        var uri = new Uri(uriString: Routes.OpenSslParameters, UriKind.Absolute);

        var workingDirectory = DirectoryHelper.OpenSslDhParametersDirectory;

        var response = await _httpClient.GetAsync(uri);

        response.EnsureSuccessStatusCode();

        await using var stream = await response.Content.ReadAsStreamAsync();

        var filePath = Path.Combine(workingDirectory, "downloaded_dhp.pem");

        if (!Directory.Exists(workingDirectory))
        {
            Directory.CreateDirectory(workingDirectory);
        }

        var fileInfo = new FileInfo(filePath);

        await using var fileStream = fileInfo.OpenWrite();

        await stream.CopyToAsync(fileStream);

        return true;
    }

    public async Task OpenSslGeneratePrivateKeyAsync(Guid receiverId)
    {
        var tokensResponse = await _tokensService.GetTokensAsync();

        var senderId = tokensResponse.Tokens.UserId;

        var fileName = $"PRIVATE_KEY_{senderId}_{receiverId}";

        var workingDirectory = DirectoryHelper.OpenSslPrivateKeysDirectory;

        var privateKeyPath = Path.Combine(workingDirectory, fileName);

        if (!Directory.Exists(workingDirectory))
        {
            Directory.CreateDirectory(workingDirectory);
        }

        var dhParametersPath = Path.Combine(DirectoryHelper.OpenSslDhParametersDirectory, "downloaded_dhp.pem");

        var command = Cli.Wrap("openssl").WithArguments(
            new[] {"genpkey", "-paramfile", dhParametersPath, "-out", privateKeyPath});

        await command.ExecuteAsync();
    }

    public async Task<bool> OpenSslGeneratePublicKeyAsync(Guid receiverId)
    {
        var tokensResponse = await _tokensService.GetTokensAsync();

        var senderId = tokensResponse.Tokens.UserId;

        var publicKeyFileName = $"PUBLIC_KEY_{senderId}_{receiverId}";

        var privateKeyFileName = $"PRIVATE_KEY_{senderId}_{receiverId}";

        var workingDirectory = DirectoryHelper.OpenSslPublicKeysDirectory;

        var publicKeyPath = Path.Combine(workingDirectory, publicKeyFileName);

        var privateKeyPath = Path.Combine(DirectoryHelper.OpenSslPrivateKeysDirectory, privateKeyFileName);

        if (!Directory.Exists(workingDirectory))
        {
            Directory.CreateDirectory(workingDirectory);
        }

        var command = Cli.Wrap("openssl").WithArguments(
            new[] {"pkey", "-in", privateKeyPath, "-pubout", "-out", publicKeyPath});

        var result = await command.ExecuteAsync();

        return true;
    }

    public async Task<bool> OpenSslCreateKeyExchangeAsync(Guid receiverId)
    {
        var tokensResponse = await _tokensService.GetTokensAsync();
        var senderId = tokensResponse.Tokens.UserId;
        var workingDirectory = DirectoryHelper.OpenSslPublicKeysDirectory;

        var publicKeyFileName = $"PUBLIC_KEY_{senderId}_{receiverId}";

        var publicKeyPath = Path.Combine(workingDirectory, publicKeyFileName);

        var route = $"{Routes.OpenSslKeyExchangeRequests}/{receiverId}";

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
        var uri = new Uri(Routes.OpenSslKeyExchangeRequests, UriKind.Absolute);
        
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
        var requests = await OpensslGetKeyExchangesAsync();

        var keyExchangeRequest = requests.FirstOrDefault(request => request.RequestId == requestId);

        if (keyExchangeRequest == null)
        {
            const string message = ResponseMessageCodes.KeyExchangeRequestNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[message];

            Console.WriteLine($"{message}. {details}");
            return false;
        }

        var route = $"{Routes.OpenSslKeyExchangeRequests}/{requestId}";

        var uri = new Uri(route, UriKind.Absolute);

        var tokensResponse = await _tokensService.GetTokensAsync();
        
        var userId = tokensResponse.Tokens.UserId;
        
        var workingDirectory = DirectoryHelper.OpenSslPublicKeysDirectory;

        var partnerId = keyExchangeRequest.Actor == Actor.Sender
            ? keyExchangeRequest.ReceiverId
            : keyExchangeRequest.SenderId;

        var publicKeyFileName = $"PUBLIC_KEY_{userId}_{partnerId}";

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

    public async Task OpensslCreateCommonSecretAsync(Guid requestId)
    {
        throw new NotImplementedException();
    }
}
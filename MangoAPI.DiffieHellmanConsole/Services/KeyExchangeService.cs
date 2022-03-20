using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.KeyExchange;
using MangoAPI.BusinessLogic.ApiQueries.KeyExchange;
using MangoAPI.DiffieHellmanConsole.Consts;
using MangoAPI.Domain.Constants;
using Newtonsoft.Json;

namespace MangoAPI.DiffieHellmanConsole.Services;

public class KeyExchangeService
{
    private readonly HttpClient _httpClient;

    public KeyExchangeService(HttpClient httpClient)
    {
        _httpClient = httpClient;

        var tokensResponse = new TokensService().GetTokensAsync().GetAwaiter().GetResult();

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

    public async Task<GetKeyExchangeResponse> GetKeyExchangesAsync()
    {
        var result = await HttpRequest.GetAsync(
            client: _httpClient,
            route: Routes.ApiKeyExchangeCngKeyExchangeRequests);

        var response = JsonConvert.DeserializeObject<GetKeyExchangeResponse>(result);

        return response;
    }

    public async Task<CreateKeyExchangeResponse> CreateKeyExchangeRequestAsync(
        Guid requestUserId,
        string publicKey)
    {
        var command = new CreateKeyExchangeRequest
        {
            PublicKey = publicKey,
            RequestedUserId = requestUserId
        };

        var result = await HttpRequest.PostWithBodyAsync(
            client: _httpClient,
            route: Routes.ApiKeyExchangeCngKeyExchangeRequests,
            body: command);

        var response = JsonConvert.DeserializeObject<CreateKeyExchangeResponse>(result);

        return response;
    }

    public async Task ConfirmOrDeclineKeyExchangeAsync(Guid requestId, string publicKeyBase64)
    {
        var request = new ConfirmOrDeclineKeyExchangeRequest
        {
            Confirmed = true,
            PublicKey = publicKeyBase64,
            RequestId = requestId
        };

        await HttpRequest.DeleteWithBodyAsync(
            client: _httpClient,
            route: Routes.ApiKeyExchangeCngKeyExchangeRequests,
            body: request);
    }

    public async Task<bool> OpenSslUploadDhParametersAsync()
    {
        var dhParametersPath = Path.Combine(DirectoryHelper.OpenSslDhParametersDirectory, "dhp.pem");

        await using var stream = File.OpenRead(dhParametersPath);

        var uri = new Uri(Routes.ApiKeyExchangeOpenSslParameters, UriKind.Absolute);

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
        var uri = new Uri(uriString: Routes.ApiKeyExchangeOpenSslParameters, UriKind.Absolute);

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
}
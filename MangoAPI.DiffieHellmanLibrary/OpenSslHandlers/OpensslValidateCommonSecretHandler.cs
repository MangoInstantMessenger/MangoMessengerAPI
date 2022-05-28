using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpensslValidateCommonSecretHandler
{
    private readonly OpenSslKeyExchangeService _keyExchangeService;

    public OpensslValidateCommonSecretHandler(OpenSslKeyExchangeService keyExchangeService)
    {
        _keyExchangeService = keyExchangeService;
    }

    public async Task ValidateCommonSecretAsync(Guid senderId, Guid receiverId)
    {
        Console.WriteLine($@"Validating common secrets for {senderId} and {receiverId} ...");

        var result = await _keyExchangeService.ValidateCommonSecretAsync(senderId, receiverId);

        Console.WriteLine(@$"Sender Hash: {result.senderHash}");
        Console.WriteLine(@$"Receiver Hash: {result.receiverHash}");
        var hashesEqual = result.senderHash == result.receiverHash;
        Console.WriteLine($@"Are hashes equal? {hashesEqual}");
        Console.WriteLine();
    }
}
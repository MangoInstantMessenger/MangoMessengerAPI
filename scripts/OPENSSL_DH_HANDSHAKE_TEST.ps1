param(
    [Parameter(Mandatory = $true, Position = 0)]
    [string] $senderId,
    [Parameter(Mandatory = $true, Position = 1)]
    [string] $senderUsername,
    [Parameter(Mandatory = $true, Position = 2)]
    [string] $senderPassword,
    [Parameter(Mandatory = $true, Position = 3)]
    [string] $receiverId,
    [Parameter(Mandatory = $true, Position = 4)]
    [string] $receiverUsername,
    [Parameter(Mandatory = $true, Position = 5)]
    [string] $receiverPassword
)

# generate dh parameters
dotnet MangoAPI.DiffieHellmanConsole.dll login $senderUsername $senderPassword;
dotnet MangoAPI.DiffieHellmanConsole.dll openssl-generate-dh-parameters;
dotnet MangoAPI.DiffieHellmanConsole.dll openssl-upload-dh-parameters;

# sender sends key exchange request
dotnet MangoAPI.DiffieHellmanConsole.dll login $senderUsername $senderPassword;
dotnet MangoAPI.DiffieHellmanConsole.dll openssl-download-dh-parameters;
dotnet MangoAPI.DiffieHellmanConsole.dll openssl-generate-private-key $receiverId;
dotnet MangoAPI.DiffieHellmanConsole.dll openssl-generate-public-key $receiverId;
dotnet MangoAPI.DiffieHellmanConsole.dll openssl-create-key-exchange $receiverId;

# receiver confirms key exchange request
dotnet MangoAPI.DiffieHellmanConsole.dll login $receiverUsername $receiverPassword;
dotnet MangoAPI.DiffieHellmanConsole.dll openssl-download-dh-parameters;
dotnet MangoAPI.DiffieHellmanConsole.dll openssl-generate-private-key $senderId;
dotnet MangoAPI.DiffieHellmanConsole.dll openssl-generate-public-key $senderId;
dotnet MangoAPI.DiffieHellmanConsole.dll openssl-print-key-exchanges;
dotnet MangoAPI.DiffieHellmanConsole.dll openssl-confirm-key-exchange $senderId;

# receiver generates common secret
dotnet MangoAPI.DiffieHellmanConsole.dll openssl-download-public-key --receiver $senderId;
dotnet MangoAPI.DiffieHellmanConsole.dll openssl-create-common-secret --receiver $senderId;

# sender generates common secret
dotnet MangoAPI.DiffieHellmanConsole.dll login $senderUsername $senderPassword;
dotnet MangoAPI.DiffieHellmanConsole.dll openssl-print-key-exchanges;
dotnet MangoAPI.DiffieHellmanConsole.dll openssl-download-public-key --sender $receiverId;
dotnet MangoAPI.DiffieHellmanConsole.dll openssl-create-common-secret --sender $receiverId;

# validate common secrets
dotnet MangoAPI.DiffieHellmanConsole.dll openssl-validate-common-secret $senderId $receiverId;

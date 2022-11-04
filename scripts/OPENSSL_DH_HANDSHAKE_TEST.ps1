# generate dh parameters
MangoAPI.DiffieHellmanConsole login $env:SENDER_EMAIL $env:SENDER_PASSWORD;
MangoAPI.DiffieHellmanConsole openssl-generate-dh-parameters;
MangoAPI.DiffieHellmanConsole openssl-upload-dh-parameters;

# sender sends key exchange request
MangoAPI.DiffieHellmanConsole login $env:SENDER_EMAIL $env:SENDER_PASSWORD;
MangoAPI.DiffieHellmanConsole openssl-download-dh-parameters;
MangoAPI.DiffieHellmanConsole openssl-generate-private-key $env:RECEIVER_ID;
MangoAPI.DiffieHellmanConsole openssl-generate-public-key $env:RECEIVER_ID;
MangoAPI.DiffieHellmanConsole openssl-create-key-exchange $env:RECEIVER_ID;

# receiver confirms key exchange request
MangoAPI.DiffieHellmanConsole login $env:RECEIVER_EMAIL $env:RECEIVER_PASSWORD;
MangoAPI.DiffieHellmanConsole openssl-download-dh-parameters;
MangoAPI.DiffieHellmanConsole openssl-generate-private-key $env:SENDER_ID;
MangoAPI.DiffieHellmanConsole openssl-generate-public-key $env:SENDER_ID;
MangoAPI.DiffieHellmanConsole openssl-print-key-exchanges;
MangoAPI.DiffieHellmanConsole openssl-confirm-key-exchange $env:SENDER_ID;

# receiver generates common secret
MangoAPI.DiffieHellmanConsole openssl-download-public-key --receiver $env:SENDER_ID;
MangoAPI.DiffieHellmanConsole openssl-create-common-secret --receiver $env:SENDER_ID;

# sender generates common secret
MangoAPI.DiffieHellmanConsole login $env:SENDER_EMAIL $env:SENDER_PASSWORD;
MangoAPI.DiffieHellmanConsole openssl-print-key-exchanges;
MangoAPI.DiffieHellmanConsole openssl-download-public-key --sender $env:RECEIVER_ID;
MangoAPI.DiffieHellmanConsole openssl-create-common-secret --sender $env:RECEIVER_ID;

# validate common secrets
MangoAPI.DiffieHellmanConsole openssl-validate-common-secret $env:SENDER_ID $env:RECEIVER_ID;

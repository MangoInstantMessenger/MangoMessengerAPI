MangoAPI.DiffieHellmanConsole login $env:SENDER_EMAIL $env:SENDER_PASSWORD;
MangoAPI.DiffieHellmanConsole cng-generate-private-key $env:RECEIVER_ID;
MangoAPI.DiffieHellmanConsole cng-create-key-exchange $env:RECEIVER_ID;

MangoAPI.DiffieHellmanConsole login $env:RECEIVER_EMAIL $env:RECEIVER_PASSWORD;
MangoAPI.DiffieHellmanConsole cng-generate-private-key $env:SENDER_ID;
MangoAPI.DiffieHellmanConsole cng-print-key-exchanges

MangoAPI.DiffieHellmanConsole cng-confirm-key-exchange $env:SENDER_ID;
MangoAPI.DiffieHellmanConsole cng-download-public-key --receiver $env:SENDER_ID;
MangoAPI.DiffieHellmanConsole cng-create-common-secret --receiver $env:SENDER_ID;

MangoAPI.DiffieHellmanConsole login $env:SENDER_EMAIL $env:SENDER_PASSWORD;
MangoAPI.DiffieHellmanConsole cng-print-key-exchanges;
MangoAPI.DiffieHellmanConsole cng-download-public-key --sender $env:RECEIVER_ID;
MangoAPI.DiffieHellmanConsole cng-create-common-secret --sender $env:RECEIVER_ID;

MangoAPI.DiffieHellmanConsole cng-validate-common-secret $env:SENDER_ID $env:RECEIVER_ID;

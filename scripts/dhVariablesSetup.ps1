$senderId="CB992AB1-7CA2-4916-B381-329C53D8C6A3"; `
$senderUsername="test1"; `
$senderPassword="test1"; `
$receiverId="7407CF51-71D2-41EC-8B15-AF41794368D6"; `
$receiverUsername="test2"; `
$receiverPassword="test2";


.\OPENSSL_DH_HANDSHAKE_TEST.ps1 -senderId $senderId -senderUsername $senderUsername -senderPassword $senderPassword -receiverId $receiverId -receiverUsername $receiverUsername -receiverPassword $receiverPassword

.\OPENSSL_DH_HANDSHAKE_TEST.ps1 `
-senderId $senderId `
-senderUsername $senderUsername `
-senderPassword $senderPassword `
-receiverId $receiverId `
-receiverUsername $receiverUsername `
-receiverPassword $receiverPassword
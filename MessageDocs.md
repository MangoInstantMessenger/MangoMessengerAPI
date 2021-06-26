# Messages

##  api/messages
**Description**: send text message
**HTTP-method**: POST 

**Parameter1**
Name: chatId
Description: The chat id
Type: string
Location: JSON
Required

**Parameter2**
Name: chatType
Description: The chat type
Type: enum
Location: JSON

**Parameter3**
Name: messageType
Description: The message type num
Type: enum
Location: JSON

Request emxaple:
```json
{
	"chatId": 7914547157,
	"chatType": "group",
	"messageType": "text",
	"message": "hello world"
}
```

**Responses**

200:
Description: Message was sent successful
Example
```json
{
    "id": 40,
    "chat_id": 7914547157,
    "user": {
  		"userId": "artdontsov",
    	"userName": "Artem228",
    	"displayName": "Artem Dontsov",
    	"userAvatar": {},
   		"phoneNumber": "+7-916-475-75-45",
    	"verified": "true",
    	"verificationCode": "78vd3H"
  	}
    "message": "Hello World!",
    "createdAt": "2021-04-26T18:23:53-00:00",
    "updatedAt": "2021-04-26T18:23:54-00:00"
}
```
404:
Description: Chat not found

## api/{chatId}/{messageId}

**Description**:  send the sticker
**HTTP-method**:  DELETE

**Parameter1**
Name: chatId
Description: The chat id
Type: int
Location: JSON
Required

**Parameter2**
Name: messageId
Description: The id of message to be deleted
Type: int
Location: JSON
Required

**Responses**:

200:
Description: Message was deleted
Example:
```json
{
  "responseMethod": "DELETE",
  "headers": {
    "statusCode": 200,
    "contentType": "application/json",
    "dateTime": "2021-04-26T18:00:00-00:00"
  },
  "body": {
    "messageDeleteId": 457
  }
}
```

404:
Description: Chat or message not found

## api/{chatId}/{messageId}

**Description**:  Update a message
**HTTP method**:  PUT

**Parameter1**
Name: chatId
Description: The chat id
Type: int
Location: JSON
Required

**Parameter2**
Name: messageId
Description: The id of message to be deleted
Type: int
Location: JSON
Required

**Responses**:

200:
Description: Message was deleted
Content: application/json
Example:
```json
{
  "requestMethod": "PUT",
  "headers": {
    "statusCode": 200,
    "contentType": "application/json",
    "dateTime": "2021-04-26T18:00:00-00:00"
  },
  "body": {
    "messageUpdateId": 874
  }
}
```

404:
Description: Chat or message not found

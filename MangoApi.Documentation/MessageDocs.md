
# Messages

## api/messages

**Description**: send text message  
**HTTP-method**: POST

**Parameter1**  
Name: chatId 
Description: The chat id 
Type: string 
Location: JSON Required

**Parameter2**  
Name: chatType 
Description: The chat type 
Type: enum 
Location: JSON

Request emxaple:

```json
{
	"chatId": 7914547157,
	"chatType": "group",
	"message": "hello world"
}
```

**Responses**

200:
Description: Message was sent successful Example

404: 
Description: Chat not found

## api/messages

**Description**: Retrieves a list of past messages of a channel.  
**HTTP-method**: GET

**Parameter1**  
Name: chatId 
Description: The chat id 
Type: string
Location: 
 JSON Required

**Parameter2**  
Name: chatType 
Description: The chat type 
Type: enum 
Location: JSON

Request emxaple:

```json
{
	"chatId": 7914547157,
	"chatType": "group"
}
```

**Responses**

200:
Description: Message was sent successful Example

404: 
Description: Chat not found

## api/messages/{messageId}

**Description**: Retrieves information on a message. 
 **HTTP-method**: GET

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
Description: Message was deleted Example:

404: 
Description: Chat or message not found

## api/{chatId}/{messageId}

**Description**: Update a message  info
**HTTP method**: PUT

**Parameter1**  
Name: message 
Description: The updated message
Type: string
Location: JSON 
Required

**Responses**:

200: 
Description: Message was deleted Content: application/json Example:

404: 
Description: Chat or message not found

## api/{chatId}/{messageId}

**Description**: Update a message  info
**HTTP method**: DELETE

**Responses**:

200: 
Description: Message was deleted Content: application/json Example:

404: 
Description: Chat or message not found
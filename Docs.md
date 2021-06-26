
# Endpoints


# Messages

##  v1/{chatId}/messages/send-text-message
**Description**: send text message

**HTTP-method**: POST 

**Parameter1**
Name: chatId
Description: The chat id
Type: string
Location: path
Required

**Parameter2**
Name: body
Description: The body of request
Required
Type: JSON
Content:
text-message
date-time (when the message was sent)
example:

```json
{
	"messageType": "text"
	"message": "hello world",
	"sendAt": "2021-04-26T18:00:00-00:00"
}
```

**Responses**

200:
Description: Message was sent successful
Content: 
application/json
Example
```json
{
	"requestMethod": "POST",
	"headers": {
		"statusCode": 200,
		"contentType": "text/plain",
		"date": "2021-04-26T18:00:00-00:00"
	}
}
```
404:
Description: Chat not found

## v1/{chatId}/messages/send-gif

**Description**:  send the gif
**HTTP-method**:  POST

**Parameter1**
Name: chatId
Description: The chat id
Type: string
Location: path
Required

**Parameter2**
Name: body
Description: The body of request
Required
Type: JSON
Content:
text-message
date-time (when the message was sent)
Example:

```json
{
	"messageType": "gif"
	"messageSrc": "helloworld.gif",
	"sentAt": "2021-04-26T18:00:00-00:00"
}
```
404:
Description: Chat not found

**Responses**

200:
Description: Message was sent successful
Content: 
application/json
Example
```json
{
	"requestMethod": "POST",
	"headers": {
		"statusCode": 200,
		"contentType": "img/gif",
		"date": "2021-04-26T18:00:00-00:00"
	}
}
```

404:
Description: Chat not found

## v1/{chatId}/messages/send-sticker

**Description**:  send the sticker
**HTTP-method**:  POST

**Parameter1**
Name: chatId
Description: The chat id
Type: string
Location: path
Required

**Parameter2**
Name: body
Description: The body of request
Required
Type: JSON
Content:
text-message
date-time (when the message was sent)
Example:

```json
{
	"messageType": "sticker"
	"messageId": 23
	"messageSrc": "sticker.svg",
	"sendAt": "2021-04-26T18:00:00-00:00"
}
```

**Responses**

200:
Description: Message was sent successful
Content: 
application/json
Example
```json
{
	"requestMethod": "POST",
	"headers": {
		"statusCode": 200,
		"contentType": "img/svg",
		"date": "2021-04-26T18:00:00-00:00"
	}
}
```
404:
Description: Chat not found

## v1/{chatId}/{messageId}/delete-message

**Description**:  send the sticker
**HTTP-method**:  DELETE

**Parameter1**
Name: chatId
Description: The chat id
Type: string
Location: path
Required

**Parameter2**
Name: messageId
Description: The id of message to be deleted
Type: int
Location: path
Required

**Responses**:

200:
Description: Message was deleted
Content: application/json
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

## v1/{chatId}/{messageId}/update-message

**Description**:  Update a message
**HTTP method**:  PUT

**Parameter1**
Name: chatId
Description: The chat id
Type: string
Location: path
Required

**Parameter2**
Name: messageId
Description: The id of message to be deleted
Type: int
Location: path
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

# User

## v1/users

**Description**:  get user by JWT
**HTTP method**:  GET 

**Parameter1**
Name: jwtToken
Description: JWT of user
Type: string
Location: cookie
Required

**Responses**:

200:
Description: User found successful
Example:
```json
{
  "responseMethod": "PUT",
  "headers": {
    "statusCode": 200,
    "contentType": "application/json",
    "dateTime": "2021-04-26T18:00:00-00:00"
  },
  "user": {
    "userId": "artdontsov",
    "userName": "Artem228",
    "displayName": "Artem Dontsov",
    "userAvatar": {},
    "phoneNumber": "+7-916-470-75-45",
    "createdAt": "2021-04-21T18:00:00-00:00",
    "updatedAt": "2021-05-12T18:00:00-00:00"
  }
}
```
404: 
Description: User not found

## v1/users/delete-user

**Description**: Delete the user account by JWT-token
**HTTP method**:  DELETE

**Parameter1**
Name: jwtToken
Description: JWT of user
Type: string
Location: cookie
Required

**Responses**:
```json
{
  "responseMethod": "PUT",
  "headers": {
    "statusCode": 200,
    "contentType": "application/json",
    "dateTime": "2021-04-26T18:00:00-00:00"
  },
  "body": {
    "deleteProperty": "user"
  }
}
```

## v1/users/change-display-name

**Description**:  Change the display name
**HTTP method**:  PUT

**Parameter1**
Name: jwtToken
Description: JWT of user
Type: string
Location: cookie
Required

**Parameter2**
Name: changedDisplayName
Description: Changed display name
Type: string
Location: body
Required

**Responses**

200:
Description: Property changed successful
```json
{
  "responseMethod": "PUT",
  "headers": {
    "statusCode": 200,
    "contentType": "application/json",
    "dateTime": "2021-04-26T18:00:00-00:00"
  },
  "body": {
    "changingProperty": "displayName"
    "changedDisplayName": "Artem"
  }
}
```
400:
Description: Field "changedDisplayName" was empty

## v1/users/change-user-name

**Description**:  Change the user name
**HTTP method**:  PUT

**Parameter1**
Name: jwtToken
Description: JWT of user
Type: string
Location: cookie
Required

**Parameter2**
Name: changedUserName
Description: Changed user name
Type: string
Location: body
Required

**Responses**

200:
Description: Property changed successful
```json
{
  "responseMethod": "PUT",
  "headers": {
    "statusCode": 200,
    "contentType": "application/json",
    "dateTime": "2021-04-26T18:00:00-00:00"
  },
  "body": {
    "changingProperty": "userName"
    "changedUserName": "Artem"
  }
}
```
400:
Description: Field "changedUserName" was empty

## v1/users/change-phone-number

**Description**:  Change the phone number
**HTTP method**:  PUT

**Parameter1**
Name: jwtToken
Description: JWT of user
Type: string
Location: cookie
Required

**Parameter2**
Name: changedPhoneNumber
Description: Changed phone number
Type: string
Location: body
Required

**Responses**
200:
Description: Property changed successful
```json
{
  "responseMethod": "PUT",
  "headers": {
    "statusCode": 200,
    "contentType": "application/json",
    "dateTime": "2021-04-26T18:00:00-00:00"
  },
  "body": {
    "changingProperty": "userName"
    "changedUserName": "Artem"
  }
}
```
400:
Description: Field "changedUserName" was empty

## v1/users/change-user-avatar

**Description**:  Change the avatar
**HTTP method**:  PUT

**Parameter1**
Name: jwtToken
Description: JWT of user
Type: string
Location: cookie
Required

**Parameter2**
Name: changedAvatar
Description: Changed avatar
Type: image
Location: body
Required

**Responses**
200:
Description: Property changed successful
```json
{
  "responseMethod": "PUT",
  "headers": {
    "statusCode": 200,
    "contentType": "application/json",
    "dateTime": "2021-04-26T18:00:00-00:00"
  },
  "body": {
    "changingProperty": "userAvatar"
    "changedAvatarSrc": "stalin.png"
  }
}
```
400:
Description: Field "changedUserName" was empty

## v1/users/change-user-description

**Description**:  Change the user description
**HTTP method**:  PUT

**Parameter1**
Name: jwtToken
Description: JWT of user
Type: string
Location: cookie
Required

**Parameter2**
Name: changedUserDescription
Description: Changed user description
Type: text
Location: body
Required

**Responses**
200:
Description: Property changed successful
```json
{
  "responseMethod": "PUT",
  "headers": {
    "statusCode": 200,
    "contentType": "application/json",
    "dateTime": "2021-04-26T18:00:00-00:00"
  },
  "body": {
    "changingProperty": "userDescription"
    "changeduserDescription": "13 y. o. C# позер"
  }
}
```
400:
Description: Field "changedUserName" was empty
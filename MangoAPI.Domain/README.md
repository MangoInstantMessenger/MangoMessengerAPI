# Domain documentation

[Database diagram](https://dbdiagram.io/d/60d66a13dd6a597148203e6b)

## User Entity

- **Id**: Primary key of user entity (GUID). Required.
- **Username**: Unique string used to login to the system. Must be from 5 to 50 alphanumeric characters. Required.
- **PasswordHash**: Byte array of the hashed password. Required.
- **PasswordSalt**: Byte array that represents salt used to hash the password. Required.
- **ImageFileName**: Name of the image file. Must be a string up to 100 various characters. Required.
- **DisplayName**: Display name of the user as string. Can be up to 50 characters. Optional.
- **Bio**: Short description of the user as string. Can be up to 120 various characters. Optional.
- **WebSite**: Web site of the user. Must be a string up to 50 various characters. Optional.
- **BirthDay**: Birthday of the user. Optional.
- **Address**: Address of the user. Must be a string up to 50 various characters. Optional.

## Message Entity

- **Id**: Primary key of message entity (GUID). Required.
- **ChatId**: Id (GUID) of the chat that the message belongs to. Required.
- **UserId**: Id (GUID) of the user that sent the message. Required.
- **Text**: Text of the message as string. Can be up to 300 various characters. Required.
- **CreatedAt**: Date and time when the message was created. Required.
- **InReplyToUser**: Display name of the user that the message is in reply to. Must be a string up to 50 characters.
  Optional.
- **InReplyToText**: Text of the message that the message is in reply to. Must be a string up to 300 characters.
  Optional.
- **AttachmentFileName**: Name of the attachment file. Must be a string up to 100 various characters. Optional.
- **UpdatedAt**: Date and time when the message was edited. Optional.

## Chat Entity

- **Id**: Primary key of chat entity (GUID). Required.
- **Title**: Title of the chat as string. Can be up to 50 characters. Required.
- **ImageFileName**: Name of the image file. Must be a string up to 50 various characters. Required.
- **Description**: Short description of the chat as string. Can be up to 150 various characters. Required.
- **MembersCount**: Number of members in the chat as integer. Must be greater or equal to zero. Required.
- **CommunityType**: Type of the chat as enum. Can be one of the following: "DirectChat = 1", "PublicChannel = 2".
  Required.
- **CreatedAt**: Date and time when the chat was created. Required.
- **LastMessageAuthor**: Display name of the user that sent last message to the chat. Must be a string up to 50
  characters.
  Optional.
- **LastMessageText**: Text of the last message to the chat. Must be a string up to 300 characters. Optional.
- **LastMessageTime**: Date and time when the last message was sent. Optional.
- **LastMessageId**: Id (GUID) of the last message to the chat. Optional.

## UserChat Entity

- ChatId uuid
- UserId uuid
- RoleId int
- IsArchived boolean

## Session Entity

- Id uuid
- UserId uuid
- ExpiresAt datetime
- CreatedAt datetime

## Contact Entity

- ContactId uuid
- UserId uuid
- CreatedAt datetime

## Personal Information Entity

- **UserId**: Id of the user (GUID). Unique. Required.
- **CreatedAt**: Date and time when the user was created. Required.
- **Facebook**: Facebook string. Must be a string up to 50 various characters. Optional.
- **Twitter**: Twitter string. Must be a string up to 50 various characters. Optional.
- **Instagram**: Instagram string. Must be a string up to 50 various characters. Optional.
- **LinkedIn**: LinkedIn string. Must be a string up to 50 various characters. Optional.
- **UpdatedAt**: Date and time when the user information was updated. Optional.


# Domain documentation

[Database diagram](https://dbdiagram.io/d/60d66a13dd6a597148203e6b)

## User Entity

1. **Id**: Primary key of user entity (GUID). Required.
2. **Username**: Unique string used to login to the system. Must be from 5 to 50 alphanumeric characters. Required.
3. **PasswordHash**: Byte array of the hashed password. Required.
4. **PasswordSalt**: Byte array that represents salt used to hash the password. Required.
5. **ImageFileName**: Name of the image file. Must be a string up to 100 various characters. Required.
6. **DisplayName**: Display name of the user as string. Can be up to 50 characters. Required.
7. **Bio**: Short description of the user as string. Can be up to 120 various characters. Optional.
8. **WebSite**: Web site of the user. Must be a string up to 50 various characters. Optional.
9. **BirthDay**: Birthday of the user. Optional.
10. **Address**: Address of the user. Must be a string up to 50 various characters. Optional.

## Message Entity

1. **Id**: Primary key of message entity (GUID). Required.
2. **ChatId**: Id (GUID) of the chat that the message belongs to. Required.
3. **UserId**: Id (GUID) of the user that sent the message. Required.
4. **Text**: Text of the message as string. Can be up to 300 various characters. Required.
5. **CreatedAt**: Date and time when the message was created. Required.
6. **InReplyToUser**: Display name of the user that the message is in reply to. Must be a string up to 50 characters.
   Optional.
7. **InReplyToText**: Text of the message that the message is in reply to. Must be a string up to 300 characters.
   Optional.
8. **AttachmentFileName**: Name of the attachment file. Must be a string up to 100 various characters. Optional.
9. **UpdatedAt**: Date and time when the message was edited. Optional.

## Chat Entity

1. **Id**: Primary key of chat entity (GUID). Required.
2. **Title**: Title of the chat as string. Can be up to 100 characters. Required.
3. **ImageFileName**: Name of the image file. Must be a string up to 100 various characters. Required.
4. **Description**: Short description of the chat as string. Can be up to 150 various characters. Required.
5. **MembersCount**: Number of members in the chat as integer. Must be greater or equal to zero. Required.
6. **CommunityType**: Type of the chat as enum. Can be one of the following: "DirectChat = 1", "PublicChannel = 2".
   Required.
7. **CreatedAt**: Date and time when the chat was created. Required.
8. **LastMessageAuthor**: Display name of the user that sent last message to the chat. Must be a string up to 50
   characters. Optional.
9. **LastMessageText**: Text of the last message to the chat. Must be a string up to 300 characters. Optional.
10. **LastMessageTime**: Date and time when the last message was sent. Optional.
11. **LastMessageId**: Id (GUID) of the last message to the chat. Optional.

## UserChat Entity

1. **ChatId**: Id of the chat as GUID. Required.
2. **UserId**: Id of the user as GUID. Required.
3. **RoleId**: Id of the role as integer. Represents enum of two values: "User = 1", "Owner = 2", where owner means
   creator
   of public group. Required.
4. **IsArchived**: Boolean value that indicates if the user archived the chat. Optional.

## Session Entity

1. **Id**: Primary key of session entity (GUID). It is also refresh token. Required.
2. **UserId**: Id of the user (GUID). Required.
3. **ExpiresAt**: Date and time when the session expires. Required.
4. **CreatedAt**: Date and time when the session was created. Required.

## Contact Entity

1. **ContactId** uuid
2. **UserId** uuid
3. **CreatedAt** datetime

## Personal Information Entity

1. **Id**: Primary of the personal info table (GUID). Unique. Required.
2. **UserId**: Id of the user (GUID). Required.
3. **CreatedAt**: Date and time when the user was created. Required.
4. **Facebook**: Facebook string. Must be a string up to 50 various characters. Optional.
5. **Twitter**: Twitter string. Must be a string up to 50 various characters. Optional.
6. **Instagram**: Instagram string. Must be a string up to 50 various characters. Optional.
7. **LinkedIn**: LinkedIn string. Must be a string up to 50 various characters. Optional.
8. **UpdatedAt**: Date and time when the user information was updated. Optional.


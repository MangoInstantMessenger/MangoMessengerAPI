# api/messages

- GET: api/messages/{chatId}
  - Returns list of all messages of specified chat by chat ID.
  - Auth: access token in request header, refresh token ID in cookies
  - Response codes: 200, 400, 401

- POST: api/messages
  - Sends message to particular chat.
  - Auth: access token in request header, refresh token ID in cookies
  - Response codes: 200, 400, 401

- PUT: api/messages
  - Updates particular message
  - Requires to be an author of message.
  - Auth: access token in request header, refresh token ID in cookies
  - Response codes: 200, 400, 401

- DELETE: api/messages/{messageId}
  - Deletes particular message
  - Requires to be an author of message.
  - Auth: access token in request header, refresh token ID in cookies
  - Response codes: 200, 400, 401
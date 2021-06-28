# api/messages

- GET: api/messages
  - Returns list of all messages of specified chat by chat ID
  - Auth: access token in request header, refresh token ID in cookies

- POST: api/messages
  - Sends message to particulat chat
  - Auth: access token in request header, refresh token ID in cookies

- PUT: api/messages
  - Updates particular message
  - Requires to by an author of message
  - Auth: access token in request header, refresh token ID in cookies

- DELETE: api/messages
  - Deletes particular message
  - Requires to by an author of message
  - Auth: access token in request header, refresh token ID in cookies
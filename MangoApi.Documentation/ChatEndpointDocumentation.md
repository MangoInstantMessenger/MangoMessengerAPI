# api/chats

- GET: api/chats
  - Returns list of all user's chats
  - Auth: access token in request header, refresh token ID in cookies

- POST: api/chats/group
  - Creates new chat
  - Auth: access token in request header, refresh token ID in cookies
  - Response codes: 200, 400, 401
  
- POST: api/chats/direct-chat
  - Modifies existent chat's public data, e.g Description, Picture, etc.
  - Auth: access token in request header, refresh token ID in cookies
  - Requires chat moderator claim
  - Response codes: 200, 400, 401

- POST: api/chats/group/join/{chatId}
  - Deletes particular chat 
  - Auth: access token in request header, refresh token ID in cookies
  - Requires chat owner claim
  - Response codes: 200, 400, 401
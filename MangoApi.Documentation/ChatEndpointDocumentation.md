# api/chats

- GET: api/chats
  - Returns list of all user's chats
  - Auth: access token in request header, refresh token ID in cookies

- POST: api/chats
  - Creates new chat
  - Auth: access token in request header, refresh token ID in cookies
  
- PUT: api/chats
  - Modifies existent chat's public data, e.g Description, Picture, etc.
  - Auth: access token in request header, refresh token ID in cookies
  - Requires chat moderator claim

- DELETE: api/chats
  - Deletes particular chat 
  - Auth: access token in request header, refresh token ID in cookies
  - Requires chat owner claim
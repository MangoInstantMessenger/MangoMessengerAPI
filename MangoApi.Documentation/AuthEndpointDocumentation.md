# api/auth

- POST: api/auth/register
  - Registers user in a messenger. Requires input: e-mail, phone, verification method (enum), password
  - Auth: allow anonymous

- POST: api/auth/verify-email
  - Sends verification request with provided user parameters: email, user ID guid. User receives proper link via email.
  - Auth: allow anonymous
  
- POST: api/auth/verify-phone
  - Sends verification request with provided user parameters: phone confirmation code.
  - Auth: allow anonymous
  
- POST: api/auth/refresh-token
  - Refreshes user's existing refresh token and access token. Refresh token ID goes to cookies. Access token stays in application's memory.
  - Auth: refresh token ID in cookies

- POST: api/auth/logout
  - Logs out from current device.
  - Auth: access token in request header, refresh token ID in cookies
  
- POST: api/auth/logout-all
  - Logs out from all devices.
  - Auth: access token in request header, refresh token ID in cookies
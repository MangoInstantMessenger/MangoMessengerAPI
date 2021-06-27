# User

## api/users

**Description**:  Create a new user
**HTTP method**:  POST

**Parameter1**
Name: jwtToken
Description: JWT of user
Type: string
Location: cookie
Required

**Parameter2**
Name: userId
Description: The user id
Type: string
Format: text
Location: body
Required

**Parameter3**
Name: userName
Description: The user name
Type: string
Format: text
Location: body
Required

**Parameter4**
Name: displayrName
Description: The user display name
Type: string
Format: text
Location: body
Required

**Parameter5**
Name: userName
Description: The user name
Type: string
Format: text
Location: body
Required

**Parameter6**
Name: phoneNumber
Description: The phone number of user
Type: string
Format: text
Location: body
Required

**Parameter7**
Name: createdAt
Description: The date when account was created
Type: time stamp
Format: date time
Location: body
Required

**Parameter8**
Name: upatedAt
Description: The date when account was updated
Type: time stamp
Format: date time
Location: body
Required

**Parameter9**
Name: verified
Description: The boolean checks are the new account was verified
Type: boolean
Format: boolean
Location: body
Required

**Parameter10**
Name: verificationCode
Description: The verification code
Type: time stamp
Format: date time
Location: body
Required

**Responses**:

200:
Description: User created successful
```json
{
	"requestMethod": "POST",
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
    	"updatedAt": "2021-05-12T18:00:00-00:00",
    	"verified": "true",
    	"verificationCode": "78vd3H"
  	}
}
```
400:
Description: One or more of the properties is filled incorrectly

## api/users

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

## api/users

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

## api/users/display-name

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
    "changingProperty": "displayName",
    "changedDisplayName": "Artem"
  }
}
```
400:
Description: Field "changedDisplayName" was empty

## api/users/user-name

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
    "changingProperty": "userName",
    "changedUserName": "Artem"
  }
}
```
400:
Description: Field "changedUserName" was empty

## api/users/phone-number

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
    "changingProperty": "userName",
    "changedUserName": "Artem"
  }
}
```
400:
Description: Field "changedUserName" was empty
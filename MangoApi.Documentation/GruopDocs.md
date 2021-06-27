# Groups

## api/chanels

**Description**: Creates a new group 
**HTTP-method**: POST

**Parameter1**  
Name: title 
Description: The title of group
Type: string
Location: JSON 
Required

**Parameter1**  
Name: userNames
Description: Array of user's usernames.
Type: Array
Location: JSON 
Optional

**Request example**
```json
{
    "title": "Channel name",
    "usernames":[
        "donald",  "petro"
    ]
}
```

**Responses**
200:
Description: Operation was successful


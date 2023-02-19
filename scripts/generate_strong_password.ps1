param (
    [Parameter(Mandatory)]
    [int] $length,
    [int] $amountOfNonAlphanumeric = 1
)
Add-Type -AssemblyName 'System.Web'
return [System.Web.Security.Membership]::GeneratePassword($length, $amountOfNonAlphanumeric).Replace("&", "*")
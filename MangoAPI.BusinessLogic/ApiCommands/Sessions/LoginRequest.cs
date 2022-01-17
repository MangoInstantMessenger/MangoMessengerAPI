using System.ComponentModel;
using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions;

public record LoginRequest
{
    [JsonConstructor]
    public LoginRequest(string email, string password)
    {
        Email = email;
        Password = password;
    }

    [DefaultValue("test@gmail.com")]
    public string Email { get; }
        
    [DefaultValue("x[?6dME#xrp=nr7q")]
    public string Password { get; }
}
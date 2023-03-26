using System.ComponentModel;
using System.Text.Json.Serialization;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions;

public record LoginRequest
{
    [JsonConstructor]
    public LoginRequest(string username, string password)
    {
        Username = username;
        Password = password;
    }

    [DefaultValue("MyUniqueUsername")] public string Username { get; }

    [DefaultValue("x[?6dME#xrp=nr7q")] public string Password { get; }
}
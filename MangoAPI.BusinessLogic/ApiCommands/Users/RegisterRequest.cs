using System.ComponentModel;
using System.Text.Json.Serialization;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public record RegisterRequest
{
    [JsonConstructor]
    public RegisterRequest(
        string email,
        string displayName,
        string password)
    {
        Email = email;
        DisplayName = displayName;
        Password = password;
    }

    [DefaultValue("test@gmail.com")]
    public string Email { get; }

    [DefaultValue("Test User")]
    public string DisplayName { get; }

    [DefaultValue("x[?6dME#xrp=nr7q")]
    public string Password { get; }
}

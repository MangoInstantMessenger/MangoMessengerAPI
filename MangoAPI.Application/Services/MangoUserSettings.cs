using MangoAPI.Application.Interfaces;

namespace MangoAPI.Application.Services;

public class MangoUserSettings : IMangoUserSettings
{
    public string Password { get; set; }

    public MangoUserSettings(string password)
    {
        Password = password;
    }
}
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public record UpdatePersonalInformationRequest
{
    [DefaultValue("test.user")]
    public string Facebook { get; }

    [DefaultValue("test.user")]
    public string Twitter { get; }

    [DefaultValue("test.user")]
    public string Instagram { get; }

    [DefaultValue("test.user")]
    public string LinkedIn { get; }

    [JsonConstructor]
    public UpdatePersonalInformationRequest(
        string facebook,
        string twitter,
        string instagram,
        string linkedIn)
    {
        Facebook = facebook;
        Twitter = twitter;
        Instagram = instagram;
        LinkedIn = linkedIn;
    }
}

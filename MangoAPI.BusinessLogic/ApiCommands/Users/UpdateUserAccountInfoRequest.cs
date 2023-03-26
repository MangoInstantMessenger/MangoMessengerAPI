using System;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public record UpdateUserAccountInfoRequest
{
    [JsonConstructor]
    public UpdateUserAccountInfoRequest(
        DateTime? birthday,
        string website,
        string username,
        string bio,
        string address,
        string displayName)
    {
        Birthday = birthday;
        Website = website;
        Username = username;
        Bio = bio;
        Address = address;
        DisplayName = displayName;
    }

    [DefaultValue("Test User")]
    public string DisplayName { get; }

    [DefaultValue("1995-04-07T00:00:00")]
    public DateTime? Birthday { get; }

    [DefaultValue("test.com")]
    public string Website { get; }

    [DefaultValue("TestUser")]
    public string Username { get; }

    [DefaultValue("Test user from $'{cityName}'")]
    public string Bio { get; }

    [DefaultValue("Finland, Helsinki")]
    public string Address { get; }
}
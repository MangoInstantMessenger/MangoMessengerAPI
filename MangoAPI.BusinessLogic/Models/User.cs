using System;
using System.ComponentModel;
using MangoAPI.Domain.Enums;

namespace MangoAPI.BusinessLogic.Models;

public record User
{
    [DefaultValue("8e08f435-8bd9-4eae-8c0b-e981f9424f19")]
    public Guid UserId { get; init; }

    [DefaultValue("Ivan Ivanov")] public string DisplayName { get; init; }

    [DefaultValue(5)] public DisplayNameColour DisplayNameColour { get; set; }

    [DefaultValue("1983-05-25T00:00:00")] public string Birthday { get; init; }

    [DefaultValue("ivan.ivanov.com")] public string Website { get; init; }

    [DefaultValue("ivan.ivanov")] public string Username { get; init; }

    [DefaultValue("User of the Mango messenger")]
    public string Bio { get; init; }

    [DefaultValue("Kyiv, Ukraine")] public string Address { get; init; }

    [DefaultValue("ivan.ivanov")] public string Facebook { get; init; }

    [DefaultValue("ivan.ivanov")] public string Twitter { get; init; }

    [DefaultValue("ivan.ivanov")] public string Instagram { get; init; }

    [DefaultValue("ivan.ivanov")] public string LinkedIn { get; init; }

    [DefaultValue("http://127.0.0.1:10000/devstoreaccount1/mangocontainer/ivan-ivanov.jpg")]
    public string PictureUrl { get; init; }
}
using System;
using System.ComponentModel;

namespace MangoAPI.BusinessLogic.Models
{
    public record User
    {
        [DefaultValue("8e08f435-8bd9-4eae-8c0b-e981f9424f19")]
        public Guid UserId { get; set; }

        [DefaultValue("Szymon")]
        public string FirstName { get; init; }

        [DefaultValue("Murawski")]
        public string LastName { get; init; }

        [DefaultValue("Szymon Murawski")]
        public string DisplayName { get; init; }

        [DefaultValue("48743615532")]
        public string PhoneNumber { get; init; }

        [DefaultValue("1983-05-25T00:00:00")]
        public string BirthdayDate { get; init; }

        [DefaultValue("szymon.murawski@wp.pl")]
        public string Email { get; init; }

        [DefaultValue("szymonmurawski.com")]
        public string Website { get; init; }

        [DefaultValue("szymon.murawski")]
        public string Username { get; init; }

        [DefaultValue("Teacher of Computer Science at WSB Poznan")]
        public string Bio { get; init; }

        [DefaultValue("Poznan, Poland")]
        public string Address { get; init; }

        [DefaultValue("szymon.murawski")]
        public string Facebook { get; init; }

        [DefaultValue("szymon.murawski")]
        public string Twitter { get; init; }

        [DefaultValue("szymon.murawski")]
        public string Instagram { get; init; }

        [DefaultValue("szymon.murawski")]
        public string LinkedIn { get; init; }

        [DefaultValue(365842)]
        public int PublicKey { get; init; }

        [DefaultValue("Uploads/szymon_picture.jpg")]
        public string PictureUrl { get; init; }
    }
}
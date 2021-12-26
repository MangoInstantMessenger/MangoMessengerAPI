using System;
using System.ComponentModel;

namespace MangoAPI.BusinessLogic.Models
{
    public record Contact
    {
        [DefaultValue("8b5c23b8-96e5-4690-9a8b-3c5ea76066be")]
        public Guid UserId { get; init; }

        [DefaultValue("razumovsky r")]
        public string DisplayName { get; init; }

        [DefaultValue("Odessa, Ukraine")]
        public string Address { get; init; }

        [DefaultValue("11011 y.o Dotnet Developer from $\"{cityName}\"")]
        public string Bio { get; init; }

        [DefaultValue(true)]
        public bool IsContact { get; set; }

        [DefaultValue("Uploads/razumovsky_picture.jpg")]
        public string PictureUrl { get; init; }

        [DefaultValue("my-email@gmail.com")]
        public string Email { get; init; }
    }
}

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    using System;
    using System.Text.Json.Serialization;

    public record UpdateUserInformationRequest
    {
        [JsonConstructor]
        public UpdateUserInformationRequest(string firstName, string lastName,
            DateTime? birthDay, string website, string address, string facebook,
            string twitter, string instagram, string linkedIn, string profilePicture)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            Website = website;
            Address = address;
            Facebook = facebook;
            Twitter = twitter;
            Instagram = instagram;
            LinkedIn = linkedIn;
            ProfilePicture = profilePicture;
        }

        public string FirstName { get; init; }
        public string LastName { get; init; }
        public DateTime? BirthDay { get; init; }

        public string Website { get; init; }
        public string Address { get; init; }

        public string Facebook { get; init; }
        public string Twitter { get; init; }
        public string Instagram { get; init; }
        public string LinkedIn { get; init; }

        public string ProfilePicture { get; init; }
    }

    public static class UpdateUserInformationRequestMapper
    {
        public static UpdateUserInformationCommand ToCommand(this UpdateUserInformationRequest model, string userId)
        {
            return new ()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                BirthDay = model.BirthDay,
                Website = model.Website,
                Address = model.Address,
                Facebook = model.Facebook,
                Twitter = model.Twitter,
                Instagram = model.Instagram,
                LinkedIn = model.LinkedIn,
                ProfilePicture = model.ProfilePicture,
                UserId = userId,
            };
        }
    }
}

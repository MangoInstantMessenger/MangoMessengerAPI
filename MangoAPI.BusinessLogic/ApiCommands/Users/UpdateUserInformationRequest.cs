namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    using System;
    using System.Text.Json.Serialization;

    public record UpdateUserInformationRequest
    {
        [JsonConstructor]
        public UpdateUserInformationRequest(
            string firstName,
            string lastName,
            DateTime? birthDay,
            string website,
            string address,
            string facebook,
            string twitter,
            string instagram,
            string linkedIn,
            string profilePicture)
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

        public string FirstName { get; }
        public string LastName { get; }
        public DateTime? BirthDay { get; }
        public string Website { get; }
        public string Address { get; }
        public string Facebook { get; }
        public string Twitter { get; }
        public string Instagram { get; }
        public string LinkedIn { get; }
        public string ProfilePicture { get; }
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

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    using Newtonsoft.Json;

    public record UpdateUserInformationRequest
    {
        [JsonConstructor]
        public UpdateUserInformationRequest(
            string firstName,
            string lastName,
            string phoneNumber,
            string birthdayDate,
            string email,
            string website,
            string username,
            string bio,
            string address,
            string facebook,
            string twitter,
            string instagram,
            string linkedIn,
            string displayName)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            BirthdayDate = birthdayDate;
            Email = email;
            Website = website;
            Username = username;
            Bio = bio;
            Address = address;
            Facebook = facebook;
            Twitter = twitter;
            Instagram = instagram;
            LinkedIn = linkedIn;
            DisplayName = displayName;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string DisplayName { get; }
        public string PhoneNumber { get; }
        public string BirthdayDate { get; }
        public string Email { get; }
        public string Website { get; }
        public string Username { get; }
        public string Bio { get; }
        public string Address { get; }
        public string Facebook { get; }
        public string Twitter { get; }
        public string Instagram { get; }
        public string LinkedIn { get; }
    }

    public static class UpdateUserInformationRequestMapper
    {
        public static UpdateUserInformationCommand ToCommand(this UpdateUserInformationRequest model, string userId)
        {
            return new()
            {
                UserId = userId,
                FirstName = model.FirstName,
                LastName = model.LastName,
                DisplayName = model.DisplayName,
                PhoneNumber = model.PhoneNumber,
                BirthdayDate = model.BirthdayDate,
                Email = model.Email,
                Website = model.Website,
                Username = model.Username,
                Bio = model.Bio,
                Address = model.Address,
                Facebook = model.Facebook,
                Twitter = model.Twitter,
                Instagram = model.Instagram,
                LinkedIn = model.LinkedIn,
            };
        }
    }
}

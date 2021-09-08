using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record UpdateUserAccountInfoRequest
    {
        [JsonConstructor]
        public UpdateUserAccountInfoRequest(string firstName, string lastName, string phoneNumber,
            string birthdayDate, string email, string website, string username, string bio, string address,
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
    }

    public static class UpdateUserAccountInfoRequestMapper
    {
        public static UpdateUserAccountInfoCommand ToCommand(this UpdateUserAccountInfoRequest model,
            string userId) => new()
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
        };
    }
}
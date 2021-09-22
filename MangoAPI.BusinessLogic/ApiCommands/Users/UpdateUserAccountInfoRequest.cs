using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record UpdateUserAccountInfoRequest
    {
        [JsonConstructor]
        public UpdateUserAccountInfoRequest(
            string firstName,
            string lastName,
            string phoneNumber,
            string birthdayDate,
            string email,
            string website,
            string username,
            string bio,
            string address,
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

        [DefaultValue("Test")]
        public string FirstName { get; }
        
        [DefaultValue("User")]
        public string LastName { get; }
        
        [DefaultValue("Test User")]
        public string DisplayName { get; }
        
        [DefaultValue("54763198")]
        public string PhoneNumber { get; }
        
        [DefaultValue("06/12/1994")]
        public string BirthdayDate { get; }
        
        [DefaultValue("test@gmail.com")]
        public string Email { get; }
        
        [DefaultValue("test.com")]
        public string Website { get; }
        
        [DefaultValue("TestUser")]
        public string Username { get; }
        
        [DefaultValue("Test user from $'{cityName}'")]
        public string Bio { get; }
        
        [DefaultValue("Finland, Helsinki")]
        public string Address { get; }
    }

    public static class UpdateUserAccountInfoRequestMapper
    {
        public static UpdateUserAccountInfoCommand ToCommand(this UpdateUserAccountInfoRequest model,
            Guid userId) => new()
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
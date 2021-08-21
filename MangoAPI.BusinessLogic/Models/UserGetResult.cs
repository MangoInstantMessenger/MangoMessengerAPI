namespace MangoAPI.BusinessLogic.Models
{
    public record UserGetResult
    {
        public string UserId { get; set; }

        public string DisplayName { get; init; }

        public string Address { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string BirthdayDate { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string WebSite { get; set; }

        public string Facebook { get; set; }

        public string Twitter { get; set; }

        public string Instagram { get; set; }

        public string LinkedIn { get; set; }

        public string Username { get; set; }

        public string Bio { get; set; }
    }
}

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record UpdateUserSocialInformationRequest
    {
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string LinkedIn { get; set; }

        public UpdateUserSocialInformationRequest(string facebook,
            string twitter, string instagram, string linkedIn)
        {
            Facebook = facebook;
            Twitter = twitter;
            Instagram = instagram;
            LinkedIn = linkedIn;
        }
    }

    public static class UpdateUserSocialInformationRequestMapper
    {
        public static UpdateUserSocialInformationCommand ToCommand(this UpdateUserSocialInformationRequest model,
            string userId) => new()
        {
            UserId = userId,
            Facebook = model.Facebook,
            Twitter = model.Twitter,
            Instagram = model.Instagram,
            LinkedIn = model.LinkedIn
        };
    }
}
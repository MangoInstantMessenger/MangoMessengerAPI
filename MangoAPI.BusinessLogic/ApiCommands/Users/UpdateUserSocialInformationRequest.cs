using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record UpdateUserSocialInformationRequest
    {
        public string Facebook { get; }
        public string Twitter { get; }
        public string Instagram { get; }
        public string LinkedIn { get; }

        [JsonConstructor]
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
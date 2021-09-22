using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record UpdateUserSocialInformationRequest
    {
        [DefaultValue("test.user")]
        public string Facebook { get; }
        
        [DefaultValue("test.user")]
        public string Twitter { get; }
        
        [DefaultValue("test.user")]
        public string Instagram { get; }
        
        [DefaultValue("test.user")]
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
            Guid userId) => new()
        {
            UserId = userId,
            Facebook = model.Facebook,
            Twitter = model.Twitter,
            Instagram = model.Instagram,
            LinkedIn = model.LinkedIn
        };
    }
}
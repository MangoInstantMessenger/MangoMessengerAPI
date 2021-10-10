using Newtonsoft.Json;
using System;
using System.ComponentModel;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public class UpdateChanelPictureRequest
    {
        [JsonConstructor]
        public UpdateChanelPictureRequest(string image, Guid chatId)
        {
            Image = image;
            ChatId = chatId;
        }

        [DefaultValue("groupImage.jpg")]
        public string Image { get; }

        [DefaultValue("ac06f62e-87de-4ca4-a683-gad77cd8ac9f")]
        public Guid ChatId { get; }
    }
}
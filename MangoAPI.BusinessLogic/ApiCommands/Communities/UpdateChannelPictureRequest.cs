using System;
using Newtonsoft.Json;

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
        
        public string Image { get; }
        public Guid ChatId { get; }
    }
}
using System.Collections.Generic;
using MangoAPI.DTO.Models;

namespace MangoAPI.DTO.Responses.Chats
{
    public class GetChatsResponse
    {
        public List<Chat> Chats { get; set; }
    }
}
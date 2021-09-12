using MangoAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    public record CreateDirectChatRequest
    {
        public CreateDirectChatRequest(Guid partnerId, ChatType myProperty)
        {
            PartnerId = partnerId;
            MyProperty = myProperty;
        }

        public Guid PartnerId { get; }

        public ChatType MyProperty { get; }
    }

    public static class CreateDirectChatRequestMapper
    {

    }
}

using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Messages;
using MangoAPI.DTO.Queries;
using MangoAPI.WebApp.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Controllers
{
    [ApiController]
    [Route("api/messages")]
    public class MessagesController : ControllerBase, IMessagesController
    {
        [HttpGet]
        public Task<IActionResult> GetChatMessages(GetChatMessagesQuery query, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        [HttpPost]
        public Task<IActionResult> SendMessage(SendChatMessageCommand command, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        [HttpPut]
        public Task<IActionResult> EditMessage(EditChatMessageCommand command, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        [HttpDelete]
        public Task<IActionResult> DeleteMessage(DeleteChatMessageCommand command, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
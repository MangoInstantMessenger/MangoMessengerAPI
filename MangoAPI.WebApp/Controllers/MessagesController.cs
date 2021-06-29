using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Messages;
using MangoAPI.DTO.Queries.Messages;
using MangoAPI.WebApp.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Controllers
{
    [ApiController]
    [Route("api/messages")]
    public class MessagesController : ControllerBase, IMessagesController
    {
        [Authorize]
        [HttpGet]
        public Task<IActionResult> GetChatMessages(GetMessagesQuery query, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        [Authorize]
        [HttpPost]
        public Task<IActionResult> SendMessage(SendMessageCommand command, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        [Authorize]
        [HttpPut]
        public Task<IActionResult> EditMessage(EditMessageCommand command, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
        
        [Authorize]
        [HttpDelete]
        public Task<IActionResult> DeleteMessage(DeleteMessageCommand command, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
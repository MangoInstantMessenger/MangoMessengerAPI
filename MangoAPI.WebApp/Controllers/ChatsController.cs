using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Chats;
using MangoAPI.DTO.Queries.Chats;
using MangoAPI.WebApp.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Controllers
{
    [ApiController]
    [Route("api/chats")]
    public class ChatsController : ControllerBase, IChatsController
    {
        [Authorize]
        [HttpGet]
        public Task<IActionResult> GetChats(GetChatsQuery query, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
        
        [Authorize]
        [HttpPost]
        public Task<IActionResult> CreateChat(CreateChatCommand command, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
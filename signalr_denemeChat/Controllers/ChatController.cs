using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using signalr_denemeChat.Hubs;
using signalr_denemeChat.Models;

namespace SignalRSample.Controllers
{

    public class ChatController : Controller
    {
        private readonly IHubContext<ChatHub> _chatHub;
        public OrderController(IHubContext<ChatHub> chatHub)
        {

            _chatHub = chatHub;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("[Controller]")]
        [HttpPost]
        public IActionResult Chat([FromBody] Chat chat)
        {
            //same bussines rules
            _chatHub.Clients.All.SendAsync("lastChat", chat);

            return Accepted();
        }

    }
}
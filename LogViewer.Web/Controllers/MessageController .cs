using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using LogViewer.Web.Hubs;

namespace LogViewer.Web.Controllers
{
    /// <summary>
    /// The purpose of this api is to comunicate with the clients via signalr,
    /// so with the help of this api developers can see errors at real time
    /// this part not completed yet.
    /// </summary>
    [Route("api/message")]
    public class MessageController : Controller
    {
        private IHubContext<MessageHub> _messageHubContext;
        public  MessageController(IHubContext<MessageHub> messageHubContext)
        {
            _messageHubContext = messageHubContext;
        }
        public JsonResult post(int id)
        {
            _messageHubContext.Clients.All.InvokeAsync("send", "Hello from the server");
            return Json(new Test { Id=20});
        }
    }


    public class Test {
        public int Id { get; set; }
    }
}

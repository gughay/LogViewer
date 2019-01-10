using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogViewer.Web.Hubs
{
    public class MessageHub  :Hub
    {
        public Task Send (String message)
        {
            return Clients.All.InvokeAsync("Send", message);
        }
    }
}

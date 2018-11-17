using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalR_Server.Hubs
{
    [HubName("ChatHub")]
    public class message : Hub
    {
        public void Send(string message)
        {
            var user = Context.User;
            var username = user.Identity.Name;

            Clients.All.SendChatMessage(message);
        }
    }
}
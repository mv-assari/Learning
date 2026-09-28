using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace InstallSignalR.Hubs
{
    public class SiteChatHub:Hub
    {
        public async Task SendNewMessage(string sender,string message)
        {
            await Clients.All.SendAsync("GetNewMessage",sender,message,DateTime.Now.ToShortDateString());
        }

        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }
    }
}

using Application.Visitors.VisitorOnline;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace WebSite.EndPoint.Hubs
{
    public class OnlineVisitorHub:Hub
    {
        private readonly IVisitorOnlineService visitorOnlineService;
        public OnlineVisitorHub(IVisitorOnlineService visitorOnlineService)
        {
            this.visitorOnlineService = visitorOnlineService;
        }

        public override Task OnConnectedAsync()
        {
            string visitorId = Context.GetHttpContext().Request.Cookies["VisitorId"];
            visitorOnlineService.ConnectUser(visitorId);
            var count = visitorOnlineService.GetCount();
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            string visitorId = Context.GetHttpContext().Request.Cookies["VisitorId"];
            visitorOnlineService.DisConnectUser(visitorId);
            var count = visitorOnlineService.GetCount();
            return base.OnDisconnectedAsync(exception);
        }
    }
}

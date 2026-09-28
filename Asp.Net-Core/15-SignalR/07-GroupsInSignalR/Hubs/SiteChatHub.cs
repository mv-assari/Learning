using InstallSignalR.Models.Services;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace InstallSignalR.Hubs
{
    public class SiteChatHub:Hub
    {
        private readonly IChatRoomService _chatRoomService;

        public SiteChatHub(IChatRoomService chatRoomService)
        {
            _chatRoomService = chatRoomService;
        }

        public async Task SendNewMessage(string sender,string message)
        {
            var roomId=await _chatRoomService.GetChatRoomForConnection(Context.ConnectionId);
            await Clients.Groups(roomId.ToString()).SendAsync("GetNewMessage",sender,message,DateTime.Now.ToShortDateString());
        }

        public override async Task OnConnectedAsync()
        {

            var roomId = await _chatRoomService.CreateChatRoom(Context.ConnectionId);


            await Groups.AddToGroupAsync(Context.ConnectionId, roomId.ToString());
            await Clients.Caller.SendAsync("GetNewMessage", "MVA support", "سلام وقت بخیر، چطور میتونم کمکتون کنم؟", DateTime.Now.ToShortTimeString());
            await base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }
    }
}

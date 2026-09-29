using InstallSignalR.Models.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace InstallSignalR.Hubs
{
    public class SiteChatHub:Hub
    {
        private readonly IChatRoomService _chatRoomService;
        private readonly IMessageService _messageService;
        public SiteChatHub(IChatRoomService chatRoomService, IMessageService messageService)
        {
            _chatRoomService = chatRoomService;
            _messageService = messageService;
        }

        public async Task SendNewMessage(string sender,string message)
        {
            var roomId=await _chatRoomService.GetChatRoomForConnection(Context.ConnectionId);

            MessageDto messageDto = new MessageDto
            {
                Message = message,
                Sender = sender,
                Time=DateTime.Now,
            };
            await _messageService.SaveChatMessage(roomId, messageDto);
            await Clients.Groups(roomId.ToString()).SendAsync("GetNewMessage", messageDto.Sender, messageDto.Message, messageDto.Time.ToShortDateString());
        }

        [Authorize]
        public async Task JoinRoom(Guid roomId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId,roomId.ToString());
        }

        [Authorize]
        public async Task LeaveRomm(Guid roomId)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, roomId.ToString());
        }

        public override async Task OnConnectedAsync()
        {

            if (Context.User.Identity.IsAuthenticated)
            {
                await base.OnConnectedAsync();
                return;
            }

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

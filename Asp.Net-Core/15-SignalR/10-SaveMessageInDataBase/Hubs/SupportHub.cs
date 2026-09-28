using InstallSignalR.Models.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace InstallSignalR.Hubs
{
    [Authorize]
    public class SupportHub:Hub
    {
        private readonly IChatRoomService _chatRoomService;
        private readonly IMessageService _messageService;

        public SupportHub(IChatRoomService chatRoomService, IMessageService messageService)
        {
            _chatRoomService = chatRoomService;
            _messageService = messageService;
        }

        public override async Task OnConnectedAsync()
        {
            var rooms =await _chatRoomService.GetAllRoom();
            await Clients.Caller.SendAsync("GetRooms", rooms);
            await base.OnConnectedAsync();
        }

        public async Task LoadMessage(Guid roomId)
        {
            var message=await _messageService.GetChatMessages(roomId);
            await Clients.Caller.SendAsync("GetNewMessage", message);
        }
    }
}

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
        private readonly IHubContext<SiteChatHub> _siteChatHub;

        public SupportHub(IChatRoomService chatRoomService, IMessageService messageService, IHubContext<SiteChatHub> siteChatHub)
        {
            _chatRoomService = chatRoomService;
            _messageService = messageService;
            _siteChatHub = siteChatHub;
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

        public async Task SendMessage(Guid roomId,string text)
        {
            var message = new MessageDto
            {
                Sender = Context.User.Identity.Name,
                Message = text,
                Time = DateTime.Now,
            };

            await _messageService.SaveChatMessage(roomId, message);
            await _siteChatHub.Clients.Group(roomId.ToString()).SendAsync("GetNewMessage", message.Sender, message.Message, message.Time.ToShortTimeString());
        }
    }
}

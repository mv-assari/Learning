using InstallSignalR.Models.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace InstallSignalR.Hubs
{
    [Authorize]
    public class SupportHub:Hub
    {
        private readonly IChatRoomService _chatRoomService;

        public SupportHub(IChatRoomService chatRoomService)
        {
            _chatRoomService = chatRoomService;
        }

        public override async Task OnConnectedAsync()
        {
            var rooms =await _chatRoomService.GetAllRoom();
            await Clients.Caller.SendAsync("GetRooms", rooms);
            await base.OnConnectedAsync();
        }
    }
}

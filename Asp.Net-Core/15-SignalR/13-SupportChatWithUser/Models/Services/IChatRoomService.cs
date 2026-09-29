using InstallSignalR.Context;
using InstallSignalR.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstallSignalR.Models.Services
{
    public interface IChatRoomService
    {
        Task<Guid> CreateChatRoom(string connectionId);
        Task<Guid> GetChatRoomForConnection(string connectionId);
        Task<List<Guid>> GetAllRoom();
    }

    public class ChatRoomService : IChatRoomService
    {
        private readonly DataBaseContext _context;

        public ChatRoomService(DataBaseContext context)
        {
            _context = context;
        }

        public async Task<Guid> CreateChatRoom(string connectionId)
        {

            var exictChatRoom = _context.ChatRooms.SingleOrDefault(p => p.ConnectionId == connectionId);
            if (exictChatRoom != null)
            {
                return await Task.FromResult(exictChatRoom.Id);
            }

            ChatRoom chatRoom = new ChatRoom
            {
                ConnectionId = connectionId,
                Id = Guid.NewGuid()
            };

            _context.ChatRooms.Add(chatRoom);
            _context.SaveChanges();
            return await Task.FromResult(chatRoom.Id);
        }

        public async Task<List<Guid>> GetAllRoom()
        {
            var rooms = _context.ChatRooms.Include(p=>p.ChatMessages.Any()).Select(p => p.Id).ToList();
            return await Task.FromResult(rooms);
        }

        public async Task<Guid> GetChatRoomForConnection(string connectionId)
        {
            var chatRoom = _context.ChatRooms.SingleOrDefault(p => p.ConnectionId == connectionId);
            return await Task.FromResult(chatRoom.Id);
        }
    }
}

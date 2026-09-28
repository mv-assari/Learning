using InstallSignalR.Context;
using InstallSignalR.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstallSignalR.Models.Services
{
    public interface IMessageService
    {
        Task SaveChatMessage(Guid roomId, MessageDto message);
        Task<List<MessageDto>> GetChatMessages(Guid roomId);
    }

    public class MessageService : IMessageService
    {
        private readonly DataBaseContext _context;

        public MessageService(DataBaseContext context)
        {
            _context = context;
        }

        public Task<List<MessageDto>> GetChatMessages(Guid roomId)
        {
            var message=_context.ChatMessages.Where(p=>p.ChatRoomId == roomId).Select(p=>new MessageDto
            {
                Message=p.Message,
                Sender=p.Sender,
                Time=p.Time,
            }).OrderBy(p=>p.Time).ToList();

            return Task.FromResult(message);
        }

        public Task SaveChatMessage(Guid roomId, MessageDto message)
        {
            var room = _context.ChatRooms.SingleOrDefault(p=>p.Id== roomId);
            ChatMessage chatMessage = new ChatMessage
            {
                ChatRoom = room,
                Message = message.Message,
                Sender = message.Sender,
                Time = message.Time,
            };

            _context.ChatMessages.Add(chatMessage);
            _context.SaveChanges();
            return Task.CompletedTask;
        }
    }

    public class MessageDto
    {
        public string Sender { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
    }
}

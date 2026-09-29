using System;
using System.Collections;
using System.Collections.Generic;

namespace InstallSignalR.Models.Entities
{
    public class ChatRoom
    {
        public Guid Id { get; set; }
        public string ConnectionId { get; set; }
        public ICollection<ChatMessage> ChatMessages { get; set; }

    }
}

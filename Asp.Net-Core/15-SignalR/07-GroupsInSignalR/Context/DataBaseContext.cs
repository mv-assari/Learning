using InstallSignalR.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace InstallSignalR.Context
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions options):base(options)
        {            
        }

        public DbSet<ChatRoom> ChatRooms { get; set; }
    }
}

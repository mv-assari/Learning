using ConfigRazorPages.Models;
using Microsoft.EntityFrameworkCore;

namespace ConfigRazorPages.Data
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> option):base(option) {}
        
        public DbSet<Product> Products { get; set; }

    }
}

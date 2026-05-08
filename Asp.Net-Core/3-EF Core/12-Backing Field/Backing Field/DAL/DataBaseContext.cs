using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataBaseContext:DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.;initial catalog=EfTest;integrated security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //اگر از قراردادهای ای اف تبعیت نکنیم از کانفیگ زیر برای بکینگ فیلد استفاده میکنیم
            modelBuilder.Entity<Blog>()
                .Property(b => b.Url)
                .HasField("_Url");
        }
    }
}

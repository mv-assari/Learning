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
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<KeylessEntity> Keylesses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.;initial catalog=EfTest;integrated security=true;"
            //,p=>p.UseQuerySplittingBehavior(QuerySplittingBehavior.SingleQuery) کوئری ها در یک درخواست به دستابیس باشه
            //,p=>p.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery) یا به صورت جداگانه ارسال شود که به صورت پیشفرض این هست
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //میتونیم با این شرط قواعد متفاوت برای جداول تعریف کرد
            //if(Database.IsRelational())
            //{
            //    modelBuilder.Entity<Post>();
            //}

            //تعریف قوانین از طریق نویگیشن ها
            //modelBuilder.Entity<Post>().Navigation(p => p.Tags).HasField("Name");

            //HasFillFactor
            //modelBuilder.Entity<Post>()
            //    .HasIndex(p => p.Id)
            //    .HasFillFactor(100);

            //تعیین مقدار عدد بعد از اعشار
            //modelBuilder.Entity<KeylessEntity>()
            //    .Property(p => p.Tonage)
            //    .HasPrecision(16,3);
        }
    }
}

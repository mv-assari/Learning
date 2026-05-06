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
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.;initial catalog=EFTest;integrated security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasSequence<int>("OrderNumber")
                .StartsAt(100)
                .IncrementsBy(5)
                .HasMax(int.MaxValue);

            modelBuilder.Entity<Order>()
                .Property(o => o.OrderNumber)
                .HasDefaultValueSql("Next Value For OrderNumber");
        }
    }
}

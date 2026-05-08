using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.;initial catalog=EfTest;integrated security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var enumToString = new ValueConverter<OrderStatus, string>(p => p.ToString(), p => (OrderStatus)Enum.Parse(typeof(OrderStatus), p));

            //modelBuilder.Entity<Order>()
            //    .Property(p=>p.OrderStatus)
            //    .HasConversion(p=>p.ToString(),p=>(OrderStatus)Enum.Parse(typeof(OrderStatus), p));

            //این مورد مثل بالا عمل میکنه ولی میشه به راحتی در جاهای مختلف ازش استفاده کرد
            //modelBuilder.Entity<Order>()
            //    .Property(o => o.OrderStatus)
            //    .HasConversion(enumToString);

            //نمیخواد به صورت دستی این کارو انجام بدیم خود ای اف چندتا ازینا به صورت توکار داره
            var enumToString2 = new EnumToStringConverter<OrderStatus>();

            modelBuilder.Entity<Order>()
                .Property(p => p.OrderStatus)
                .HasConversion(enumToString2);
                //.HasConversion(new EnumToStringConverter<OrderStatus>());


            var boolToString = new BoolToStringConverter("No", "Yes");

            modelBuilder.Entity<Order>()
                .Property(p=>p.Done)
                .HasConversion(boolToString);

            //مورد استفاده دیگر این قابلیت در کدگذاری کردن داده ها در سمت دیتابیس هست
            modelBuilder.Entity<User>()
                .Property(P=>P.Email)
                .HasConversion(p=>Base64Encode(p),p=>Base64Decode(p));
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes=Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes=Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}

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
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.;initial catalog=EfTest;integrated security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Category>().HasMany(p => p.Products).WithOne(p => p.Category);

            //modelBuilder.Entity<Product>().HasOne(p => p.Category).WithMany(p => p.Products);

            //modelBuilder.Entity<Category>().HasMany(c => c.Products).WithOne();


            //اگر خودمون به صورت دستی بخوایم کلید خارجی تعریف کنیم
            //modelBuilder.Entity<Category>()
            //    .HasMany(c => c.Products)
            //    .WithOne(p => p.Category)
            //    .HasForeignKey(p => p.FK_CategoryId)
            //    .HasConstraintName("FK_C_P");


            //اگر از هیج قراردادی و پراپرتی برای ارتباط بین دو جدول استفاده نکنیم و به صورت دستی بخواهیم انجام بدیم
            //modelBuilder.Entity<Product>()
            //    .HasOne<Category>()
            //    .WithMany()
            //    .HasForeignKey(p => p.FK_CategoryId)
            //    .IsRequired(false); //اگر بخواهیم کلید خارجی را غیراجباری تعریف کنیم یا جلوی پراپرتی ؟ میزاریم

            //در این قسمت میتوانیم که نوع حذف را مشخص کنیم
            //modelBuilder.Entity<Product>()
            //    .HasOne(p=>p.Category)
            //    .WithMany(c=>c.Products)
            //    .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.ProductImage)
                .WithOne(i => i.Product)
                .HasPrincipalKey<ProductImage>(i => i.FK_ProductId);
        }
    }
}

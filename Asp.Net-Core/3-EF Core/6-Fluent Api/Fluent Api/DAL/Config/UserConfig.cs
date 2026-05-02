using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(p => p.UserId).HasName("Id"); //این مورد فقط نام کلید را تغییر میدهد
            builder.Property(p => p.UserId).HasColumnName("Id");// این مورد فقط نام ستون کلید را تغییر میدهد

            builder.HasAlternateKey(p => p.NationalCode).HasName("AlternateKey_NationalCode");//این مورد فقط نام کلید را تغییر میدهد
            builder.Property(p => p.NationalCode).HasColumnName("NationalMeli");//این مورد فقط نام کلید را تغییر میدهد

            builder.HasIndex(p => p.PhoneNumber).IsUnique();

            //builder.HasIndex(p => new { p.PhoneNumber ,p.LastName}); برای ایجاد چند ایندکس هست
            //builder.HasKey(p => new {p.KeyId,p.KeyId2}); برای ایجاد دوکلید اصلی استفاده میشود
        }
    }
}

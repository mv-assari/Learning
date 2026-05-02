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
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("tbl_Prodcut", schema: "prod");
            builder.Property(p=>p.Name).IsRequired();
            builder.Ignore(p => p.temp);
            builder.Property(p => p.Id).HasColumnName("Prodcut_Id");
            builder.Property(p => p.Name).HasColumnType("varchar(20)");
            builder.Property(p => p.Description).HasMaxLength(750);
        }
    }
}

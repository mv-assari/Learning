using Application.Interfaces.Contexts;
using Domain.Attributes;
using Domain.Catalogs;
using Domain.Users;
using Microsoft.EntityFrameworkCore;
using Persistence.EntityConfigurations;
using Persistence.Seeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Persistence.Contexts
{
    public class DataBaseContext:DbContext,IDataBaseContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options):base(options) { }

        public DbSet<CatalogBrand> CatalogBrands { get; set; }
        public DbSet<CatalogType> CatalogTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var item in modelBuilder.Model.GetEntityTypes())
            {
                if(item.ClrType.GetCustomAttributes(typeof(AuditableAttribute),true).Length>0)
                {
                    modelBuilder.Entity(item.Name).Property<DateTime?>("InsertTime").HasDefaultValue(DateTime.Now);
                    modelBuilder.Entity(item.Name).Property<DateTime?>("UpdateTime");
                    modelBuilder.Entity(item.Name).Property<bool>("IsRemoved").HasDefaultValue(false);
                    modelBuilder.Entity(item.Name).Property<DateTime?>("RemoveTime");
                }
            }

            modelBuilder.Entity<CatalogType>().HasQueryFilter(p => EF.Property<bool>(p, "IsRemoved") == false);

            modelBuilder.ApplyConfiguration(new CatalogBrandEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CatalogTypeEntityTypeConfiguration());

            DataBaseContextSeed.CatalogSeed(modelBuilder);
            
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            var modifiedEnteries = ChangeTracker.Entries().Where(p => p.State == EntityState.Added ||
                                                                    p.State == EntityState.Modified ||
                                                                    p.State == EntityState.Deleted);

            foreach (var item in modifiedEnteries)
            {
                var entityType = item.Context.Model.FindEntityType(item.Entity.GetType());
                var inserted = entityType.FindProperty("InsertTime");
                var updated = entityType.FindProperty("UpdateTime");
                var isRemoved = entityType.FindProperty("IsRemoved");
                var remove = entityType.FindProperty("RemoveTime");

                if (item.State == EntityState.Added && inserted!=null)
                {
                    item.Property("InsertTime").CurrentValue = DateTime.Now;
                }

                if (item.State == EntityState.Modified && updated != null)
                {
                    item.Property("UpdateTime").CurrentValue = DateTime.Now;
                }

                if (item.State == EntityState.Deleted && isRemoved != null && remove != null)
                {
                    item.Property("IsRemoved").CurrentValue = true;
                    item.Property("RemoveTime").CurrentValue = DateTime.Now;
                    item.State = EntityState.Modified;
                }
            }
            return base.SaveChanges();
        }
    }
}

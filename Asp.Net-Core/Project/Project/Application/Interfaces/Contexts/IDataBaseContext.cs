using Domain.Baskets;
using Domain.Catalogs;
using Domain.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Interfaces.Contexts
{
    public interface IDataBaseContext
    {
        DbSet<CatalogBrand> CatalogBrands { get; set; }
        DbSet<CatalogType> CatalogTypes { get; set; }
        DbSet<CatalogItem> catalogItems { get; set; }
        DbSet<Basket> Baskets { get; set; }
        DbSet<BasketItem> BasketItems { get; set; }
        public int SaveChanges();
        public int SaveChanges(bool acceptAllChangesOnSuccess);
        public Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}

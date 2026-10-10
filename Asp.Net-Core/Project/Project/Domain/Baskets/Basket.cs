using Domain.Attributes;
using Domain.Catalogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Baskets
{
    [Auditable]
    public class Basket
    {
        public Basket(string buyerId)
        {
            BuyerId = buyerId; 
        }
        public int Id { get; set; }
        public string BuyerId { get;private set; }
        private readonly List<BasketItem> _items = new List<BasketItem>();
        public ICollection<BasketItem> Items => _items.AsReadOnly();

        public void AddItem(int unitPrice, int quantity, int catalogItemId)
        {
            if (!Items.Any(p => p.CatalogItemId == catalogItemId))
            {
                _items.Add(new BasketItem(unitPrice, quantity, catalogItemId));
                return;
            }

            var existingItem = Items.FirstOrDefault(p=>p.CatalogItemId==catalogItemId);
            existingItem.AddQuantity(quantity);
        }
        
    }

    [Auditable]
    public class BasketItem
    {
        public BasketItem(int unitPrice, int quantity, int catalogItemId)
        {
            UnitPrice = unitPrice;
            SetQuantity(quantity);
            CatalogItemId = catalogItemId;
        }

        public int Id { get; set; }
        public int UnitPrice { get;private set; }
        public int Quantity { get;private set; }
        public CatalogItem CatalogItem { get;private set; }
        public int CatalogItemId { get;private set; }
        public int BasketId { get;private set; }

        public void AddQuantity(int quantity)
        {
            Quantity += quantity;
        }

        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }
    }
}

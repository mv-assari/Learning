using Application.Catalogs.CatalogItems.UriComposre;
using Application.Interfaces.Contexts;
using Domain.Baskets;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BasketsService
{
    public interface IBasketService
    {
        BasketDto GetOrCreateBasketForUser(string buyerId);
    }

    public class BasketService : IBasketService
    {
        private readonly IDataBaseContext context;
        private readonly IUriComposerService uriComposerService;

        public BasketService(IDataBaseContext context, IUriComposerService uriComposerService)
        {
            this.context = context;
            this.uriComposerService = uriComposerService;
        }

        public BasketDto GetOrCreateBasketForUser(string buyerId)
        {
            var basket = context.Baskets
                .Include(p=>p.Items)
                .ThenInclude(p=>p.CatalogItem)
                .ThenInclude(p=>p.CatalogItemImages)
                .SingleOrDefault(p => p.BuyerId == buyerId);
            if (basket ==null)
            {
                return CreateBasketForUser(buyerId);
            }

            return new BasketDto
            {
                Id = basket.Id,
                BuyerId = buyerId,
                Items = basket.Items.Select(p => new BasketItemDto
                {
                    CatalogItemid = p.CatalogItemId,
                    Id = p.Id,
                    CatalogName = p.CatalogItem.Name,
                    Quantity = p.Quantity,
                    UnitPrice = p.UnitPrice,
                    ImageUrl = uriComposerService.ComposeImageUri(p?.CatalogItem?.CatalogItemImages?.FirstOrDefault()?.Src ?? "")
                }).ToList()
            };
        }

        private BasketDto CreateBasketForUser(string BuyerId)
        {
            Basket basket = new Basket(BuyerId);
            context.Baskets.Add(basket);
            context.SaveChanges();
            return new BasketDto
            {
                BuyerId = basket.BuyerId,
                Id = basket.Id,
            };
        }
    }

    public class BasketDto
    {
        public int Id { get; set; }
        public string BuyerId { get; set; }
        public List<BasketItemDto> Items { get; set; } = new List<BasketItemDto>();

        public int Total()
        {
            if (Items.Count > 0)
            {
                return Items.Sum(p => p.UnitPrice * p.Quantity);
            }
            return 0;
        }
    }

    public class BasketItemDto
    {
        public int Id { get; set; }
        public int CatalogItemid { get; set; }
        public string CatalogName { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }
    } 
}

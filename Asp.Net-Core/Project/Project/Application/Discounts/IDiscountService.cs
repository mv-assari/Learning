using Application.Dtos;
using Application.Interfaces.Contexts;
using Domain.Discounts;
using Domain.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Discounts
{
    public interface IDiscountService
    {
        List<CatlogItemDto> GetCatalogItems(string searchKey);
        bool ApplyDiscountInBasket(string CoponCode, int BasketId);
        bool RemoveDiscountFromBasket(int BasketId);
        BaseDto IsDiscountValid(string couponCode, User user);
    }

    public class DiscountService : IDiscountService
    {

        private readonly IDataBaseContext context;
        private readonly IDiscountHistoryService discountHistoryService;

        public DiscountService(IDataBaseContext context
            , IDiscountHistoryService discountHistoryService)
        {
            this.context = context;
            this.discountHistoryService = discountHistoryService;
        }

        public bool ApplyDiscountInBasket(string CoponCode, int BasketId)
        {
            var basket = context.Baskets
                .Include(p => p.Items)
                .Include(p => p.AppliedDiscount)
                .FirstOrDefault(p => p.Id == BasketId);

            var discount = context.Discounts.Where(p => p.CouponCode.Equals(CoponCode))
                .FirstOrDefault();

            basket.ApplyDiscountCode(discount);
            context.SaveChanges();
            return true;
        }

        public List<CatlogItemDto> GetCatalogItems(string searchKey)
        {
            if (!string.IsNullOrEmpty(searchKey))
            {
                var data = context.catalogItems
                    .Where(p => p.Name.Contains(searchKey))
                    .Select(p => new CatlogItemDto
                    {
                        Id = p.Id,
                        Name = p.Name
                    }).ToList();
                return data;
            }
            else
            {
                var data = context.catalogItems
                    .OrderByDescending(p => p.Id)
                    .Take(10)
                    .Select(p => new CatlogItemDto
                    {
                        Id = p.Id,
                        Name = p.Name
                    }).ToList();
                return data;
            }

        }

        public BaseDto IsDiscountValid(string couponCode, User user)
        {
            var discount = context.Discounts
                .Where(p => p.CouponCode.Equals(couponCode)).FirstOrDefault();
            if (discount == null)
            {
                return new BaseDto(new List<string> { "کد تخفیف معتبر نمی باشد" }, isSuccess: false);
            }

            var now = DateTime.UtcNow;
            if (discount.StartDate.HasValue)
            {
                var startDate = DateTime.SpecifyKind(discount.StartDate.Value, DateTimeKind.Utc);
                if (startDate.CompareTo(now) > 0)
                    return new BaseDto( new List<string>
                    { "هنوز زمان استفاده از این کد تخفیف فرا نرسیده است" }, false);
            }
            if (discount.EndDate.HasValue)
            {
                var endDate = DateTime.SpecifyKind(discount.EndDate.Value, DateTimeKind.Utc);
                if (endDate.CompareTo(now) < 0)
                    return new BaseDto( new List<string> { "کد تخفیف منقضی شده است" }, false);
            }

            var checkLimit = CheckDiscountLimitations(discount, user);

            if (checkLimit.IsSuccess == false)
                return checkLimit;
            return new BaseDto( null, true);

        }


        private BaseDto CheckDiscountLimitations(Discount discount, User user)
        {
            switch (discount.DiscountLimitation)
            {
                case DiscountLimitationType.Unlimited:
                    {
                        return new BaseDto(null, true);
                    }
                case DiscountLimitationType.NTimesOnly:
                    {
                        var totalUsage = discountHistoryService.GetAllDiscountUsageHistory(discount.Id, null, 0, 1).Data.Count();
                        if (totalUsage < discount.LimitationTimes)
                        {
                            return new BaseDto(null, true);

                        }
                        else
                        {
                            return new BaseDto(new List<string> { "ظرفیت استفاده از این کد تخفیف تکمیل شده است" }, false);

                        }
                    }
                case DiscountLimitationType.NTimesPerCustomer:
                    {
                        if (user != null)
                        {
                            var totalUsage = discountHistoryService.GetAllDiscountUsageHistory(discount.Id, user.Id, 0, 1).Data.Count();
                            if (totalUsage < discount.LimitationTimes)
                            {
                                return new BaseDto(null, true);
                            }
                            else
                            {
                                return new BaseDto(new List<string> { "تعدادی که شما مجاز به استفاده از این تخفیف بوده اید به پایان رسیده است" }, false);
                            }
                        }
                        else
                        {
                            return new BaseDto(null, true);
                        }
                    }
                default:
                    break;
            }
            return new BaseDto(null, true);

        }

        public bool RemoveDiscountFromBasket(int BasketId)
        {
            var basket = context.Baskets.Find(BasketId);

            basket.RemoveDescount();
            context.SaveChanges();
            return true;
        }
    }

    public class CatlogItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

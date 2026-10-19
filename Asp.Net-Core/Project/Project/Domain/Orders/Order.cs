using Domain.Attributes;
using Domain.Catalogs;
using Domain.Discounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Orders
{
    [Auditable]
    public class Order
    {
        public Order()
        {
                
        }
        public Order(string userId, Address address,
            List<OrderItem> orderItems,
            PaymentMethod paymentMethod
            , Discount discount)
        {
            UserId = userId;
            Address = address;
            _orderItems = orderItems;
            PaymentMethod = paymentMethod;
            if (discount != null)
            {
                ApplyDiscountCode(discount);
            }
        }
        public int Id { get; set; }
        public string UserId { get; private set; }
        public DateTime OrderDate { get; private set; }= DateTime.Now;
        public Address Address { get; private set; }
        public PaymentMethod PaymentMethod { get; private set; }
        public PaymentStatus PaymentStatus { get; private set; }
        public OrderStatus OrderStatus { get; private set; }
        private readonly List<OrderItem> _orderItems = new List<OrderItem>();
        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems.AsReadOnly();
        public CatalogItem CatalogItem { get; set; }
        public decimal DiscountAmount { get; private set; }
        public Discount AppliedDiscount { get; private set; }
        public int? AppliedDiscountId { get; private set; }

        public int TotalPrice()
        {
            int totalPrice = _orderItems.Sum(p => p.UnitPrice * p.Units);
            if (AppliedDiscount!=null)
            {
                totalPrice -= AppliedDiscount.GetDiscountAmount(totalPrice);
            }
            return totalPrice;
        }

        /// <summary>
        /// دریافت مبلغ کل بدونه در نظر گرفتن کد تخفیف
        /// </summary>
        /// <returns></returns>
        public int TotalPriceWithOutDiescount()
        {
            int totalPrice = _orderItems.Sum(p => p.UnitPrice * p.Units);
            return totalPrice;
        }

        public void ApplyDiscountCode(Discount discount)
        {
            this.AppliedDiscount = discount;
            this.AppliedDiscountId = discount.Id;
            this.DiscountAmount = discount.GetDiscountAmount(TotalPrice());
        }

        public void PaymentDone()
        {
            PaymentStatus = PaymentStatus.Paid;
        }

        public void OrderDelivered()
        {
            OrderStatus = OrderStatus.Delivered;
        }

        public void OrderReturned()
        {
            OrderStatus = OrderStatus.Returned;
        }

        public void OrderCancelled()
        {
            OrderStatus = OrderStatus.Cancelled;
        }

    }

    [Auditable]
    public class OrderItem
    {
        public OrderItem()
        {
            //ef core
        }        
        public OrderItem(int catalogItemId, string productName, string pictureUri, int unitPrice, int units)
        {
            CatalogItemId = catalogItemId;
            ProductName = productName;
            PictureUri = pictureUri;
            UnitPrice = unitPrice;
            Units = units;
        }
        public int Id { get; set; }
        public int CatalogItemId { get; private set; }
        public string ProductName { get; private set; }
        public string PictureUri { get; private set; }
        public int UnitPrice { get; private set; }
        public int Units { get; private set; }
    }

    public class Address
    {
        public Address(string state, string city, string zipCode, string postalAddress, string reciverName)
        {
            State = state;
            City = city;
            ZipCode = zipCode;
            PostalAddress = postalAddress;
            ReciverName = reciverName;
        }

        public string State { get; private set; }
        public string City { get; private set; }
        public string ZipCode { get; private set; }
        public string PostalAddress { get; private set; }
        public string ReciverName { get; private set; }
    }

    public enum PaymentMethod
    {
        /// <summary>
        /// پرداخت آنلاین
        /// </summary>
        OnlinePayment=0,
        /// <summary>
        /// پرداخت در محل
        /// </summary>
        PaymentOnTheSpot=1
    }
    
    public enum PaymentStatus
    {
        /// <summary>
        /// منتظرپرداخت
        /// </summary>
        WaitinForPayment=0,
        /// <summary>
        /// پرداخت انجام شد
        /// </summary>
        Paid=1
    }

    public enum OrderStatus
    {
        /// <summary>
        /// درحال پردازش
        /// </summary>
        Processing=0,
        /// <summary>
        /// تحویل داده شد
        /// </summary>
        Delivered=1,
        /// <summary>
        /// مرجوعی
        /// </summary>
        Returned=2,
        /// <summary>
        /// لغوشد
        /// </summary>
        Cancelled=3
    }
}

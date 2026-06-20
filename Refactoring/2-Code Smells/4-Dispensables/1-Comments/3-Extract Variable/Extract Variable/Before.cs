using System;

namespace Extract_Variable
{
    public class Before
    {
    }

    public class OrderChecker
    {
        public bool CanPlaceOrder(User user, Order order)
        {
            return user.CreditScore > 650
                && user.YearsAsMember > 2
                && !user.IsBlacklisted
                && order.TotalAmount < user.AccountBalance * 0.5m
                && order.Items.Count >= 1
                && order.Items.Count <= 10;
        }
    }
}

using System;

namespace Extract_Variable
{
    public class After
    {
    }

    public class OrderChecker
    {
        public bool CanPlaceOrder(User user, Order order)
        {
            bool hasGoodCredit = user.CreditScore > 650;
            bool isLongTermMember = user.YearsAsMember > 2;
            bool isNotBlacklisted = !user.IsBlacklisted;
            bool canAffordOrder = order.TotalAmount < user.AccountBalance * 0.5m;
            bool hasItems = order.Items.Count >= 1;
            bool hasReasonableItemCount = order.Items.Count <= 10;

            return hasGoodCredit
                && isLongTermMember
                && isNotBlacklisted
                && canAffordOrder
                && hasItems
                && hasReasonableItemCount;
        }
    }
}

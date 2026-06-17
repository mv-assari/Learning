using System;
using System.Reflection.Emit;

namespace Duplicate_Observed_Data
{
    public class CustomerForm_After : Form
    {
        private TextBox nameTextBox;
        private Label resultLabel;
        private Customer _Customer;

        public CustomerForm_After()
        {
            _Customer = new Customer();
        }

        private void SyncFromDomain()
        {
            nameTextBox.Text = _Customer.CustomerName;
        }

        private void SyncToDomain()
        {
            _Customer.CustomerName = nameTextBox.Text;
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            SyncToDomain();
            decimal discount =_Customer.CalculateDiscount();
            resultLabel.Text = $"تخفیف: {discount:P0}";
        }
    }

    public class Customer
    {
        public string CustomerName { get; set; }

        public decimal CalculateDiscount()
        {
            // این منطق تجاریه، ولی توی Form هست!
            if (CustomerName.Length > 10)
                return 0.1m;
            return 0.05m;
        }
    }
}

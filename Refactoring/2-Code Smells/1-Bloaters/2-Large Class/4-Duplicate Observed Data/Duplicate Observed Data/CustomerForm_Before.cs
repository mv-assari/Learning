using System;
using System.Reflection.Emit;

namespace Duplicate_Observed_Data
{
    public class CustomerForm_Before : Form
    {
        private TextBox nameTextBox;
        private Label resultLabel;

        public string CustomerName
        {
            get => nameTextBox.Text;
            set => nameTextBox.Text = value;
        }

        public decimal CalculateDiscount()
        {
            // این منطق تجاریه، ولی توی Form هست!
            if (CustomerName.Length > 10)
                return 0.1m;
            return 0.05m;
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            decimal discount = CalculateDiscount();
            resultLabel.Text = $"تخفیف: {discount:P0}";
        }
    }
}

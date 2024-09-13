using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CoffeeShopPOS
{
    public partial class Form1 : Form
    {
        private List<OrderItem> _orderItems;

        public Form1()
        {
            InitializeComponent();
            _orderItems = new List<OrderItem>();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text;
            if (double.TryParse(txtItemPrice.Text, out double itemPrice))
            {
                _orderItems.Add(new OrderItem { Name = itemName, Price = itemPrice });
                lstOrderItems.Items.Add($"{itemName}: ${itemPrice:F2}");
                txtItemName.Clear();
                txtItemPrice.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid price.");
            }
        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            double total = CalculateTotal();
            lblTotal.Text = $"Total: ${total:F2}";
        }

        private double CalculateTotal()
        {
            double total = 0;
            foreach (var item in _orderItems)
            {
                total += item.Price;
            }
            return total;
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            string receipt = "Receipt:\n";
            foreach (var item in _orderItems)
            {
                receipt += $"{item.Name}: ${item.Price:F2}\n";
            }
            receipt += $"Total: ${CalculateTotal():F2}";
            MessageBox.Show(receipt);
        }
    }

    public class OrderItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
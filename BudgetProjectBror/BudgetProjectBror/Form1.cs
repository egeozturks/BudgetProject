using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetProjectBror
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ShoppingManager shoppingManager = new ShoppingManager(14500);
        private void Form1_Load(object sender, EventArgs e)
        {
            dgrwShopping.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var TotalShoppingButtonText = "Toplam Harcanan Parayı Hesapla";
            var RemainingMoneyButtonText = "Geriye Kalan Harcanabilir Parayı Hesapla";

            btnTotalShopping.Text = TotalShoppingButtonText;
            btnRemainingMoney.Text = RemainingMoneyButtonText;

            dgrwShopping.DataSource = shoppingManager.GetShoppings();
        }

        private void btnTotalShopping_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toplam Harcanan Para : " + shoppingManager.CalculateTotalCost().ToString() + " Kron");// This line, string words used the first and then you don't have to use .ToString() - If you don't use string words you have to use .ToString()
        }

        private void btnRemainingMoney_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Geriye Kalan Harcanabilir Para : " + shoppingManager.CalculateRemainingMoney() + " Kron"); //This line didn't use .ToString() cause you used string words before the method
        }
    }
}



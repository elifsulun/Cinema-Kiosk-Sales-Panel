using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables
{
    public partial class CinemaKioskSalesPanel : Form
    {
        public CinemaKioskSalesPanel()
        {
            InitializeComponent();
        }

        int totalPrice = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int popcornCount, waterCount, teacount, ticketCount, price;
            popcornCount = Convert.ToInt16(txtPopcorn.Text);
            waterCount = Convert.ToInt16(txtWater.Text);
            teacount = Convert.ToInt16(txtTea.Text);
            ticketCount = Convert.ToInt16(txtTicket.Text);
            
            price = (popcornCount * 4) + (waterCount * 1) + (teacount * 2) + (ticketCount * 8);
            lblPrice.Text = "₺ " + price.ToString();
            
            totalPrice = totalPrice + price;
            lblTotalPrice.Text = " ₺ " + totalPrice.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPopcorn.Text = "";
            txtWater.Text = "";
            txtTea.Text = "";
            txtTicket.Text = "";
            lblPrice.Text = "₺ 0";

            txtPopcorn.Focus();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShopV2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BuyProductButton_Click(object sender, EventArgs e)
        {
            BuyProduct bp = new BuyProduct();
            bp.Show();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct();
            ap.Show();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            CheckProduct cP = new CheckProduct();
            cP.Show();
        }

        private void SoldForDayButton_Click(object sender, EventArgs e)
        {
            SoldForToday sold = new SoldForToday();
            sold.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

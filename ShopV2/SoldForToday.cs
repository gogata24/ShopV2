using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopV2
{
    public partial class SoldForToday : Form
    {
        public SoldForToday()
        {
            InitializeComponent();
        }

        private void SoldForTodayButton_Click(object sender, EventArgs e)
        {
            foreach(var x in BuyProduct.products)
            {
                listSoldForToday.Items.Add(x.Print());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ShopV2
{
    public partial class CheckProduct : Form
    {
        public CheckProduct()
        {
            InitializeComponent();
        }

        private void Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> items = new List<string>();
            using (SqlConnection con = new SqlConnection("Data Source=Georgi\\SQLEXPRESS;Initial Catalog=ShopV2;Integrated Security=True;TrustServerCertificate=True"))
            {
                string qry = $"Select name from Products where id_category ={Category.SelectedIndex + 1}";
                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string item = reader.GetString(0);
                            Product.Items.Add(item);
                        }
                    }
                }
                con.Close();
            }

        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            string quanity = "";
            using (SqlConnection con = new SqlConnection("Data Source=Georgi\\SQLEXPRESS;Initial Catalog=ShopV2;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();
                using (SqlDataReader reader = new SqlCommand($"select quanity from Products where name = '{Product.Text}'", con).ExecuteReader())
                {
                    List<string> prices = new List<string>();
                    while (reader.Read())
                    {
                        quanity = reader.GetDecimal(0).ToString("f2");

                    }
                }
                con.Close();
            }
            listCheckProducts.Items.Add($"{Product.Text} -> quanity = {quanity}");
            Product.Text = String.Empty;
        }
    }
}

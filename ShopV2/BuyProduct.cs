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
    public partial class BuyProduct : Form
    {
        public static List<Product> products = new List<Product>();
        public BuyProduct()
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

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            string price = "";
            using (SqlConnection con = new SqlConnection("Data Source=Georgi\\SQLEXPRESS;Initial Catalog=ShopV2;Integrated Security=True;TrustServerCertificate=True"))
            {
                string qry = $"update Products set quanity = quanity - {Stock.Text} where name = '{Product.Text}'";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteScalar();
                
                using (SqlDataReader reader = new SqlCommand($"select price from Products where name = '{Product.Text}'", con).ExecuteReader())
                {


                    List<string> prices = new List<string>();
                    while (reader.Read())
                    {
                        price = reader.GetDecimal(0).ToString("f2");

                    }
                }
                con.Close();
                Product p = new Product(Product.Text, double.Parse(Stock.Text), decimal.Parse(price));
                products.Add(p);
                listProducts.Items.Add(p.Print());
            }
            Product.Text = string.Empty;
            Stock.Text = string.Empty;

        }
            
       

        private void BuyProduct_Load(object sender, EventArgs e)
        {
           
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

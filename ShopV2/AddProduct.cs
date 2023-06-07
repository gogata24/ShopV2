using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShopV2
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void ProductAddButton_Click(object sender, EventArgs e)
        {
            if(NewProduct.Checked)
            {
                using (SqlConnection con = new SqlConnection("Data Source=Georgi\\SQLEXPRESS;Initial Catalog=ShopV2;Integrated Security=True;TrustServerCertificate=True"))
                {
                    string qry = $"INSERT INTO Products(name, price, quanity, id_category) values ('{ProductName.Text}', {Price.Text}, {Stock.Text}, {(Category.SelectedIndex + 1)})";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.ExecuteScalar();
                    con.Close();
                }
            }
            else
            {
                if (AddExistProduct.Checked)
                {
                    using (SqlConnection con = new SqlConnection("Data Source=Georgi\\SQLEXPRESS;Initial Catalog=ShopV2;Integrated Security=True;TrustServerCertificate=True"))
                    {
                        string qry = $"Update Products set quanity = quanity + {Stock.Text} where name = '{ExistProduct.GetItemText(this.ExistProduct.SelectedItem)}'";
                        con.Open();
                        SqlCommand cmd = new SqlCommand(qry, con);
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteScalar();
                        con.Close();
                    }
                }

            }
            ProductName.Text = string.Empty;
            Price.Text = string.Empty;
            Stock.Text = string.Empty;
            ExistProduct.Text = string.Empty;
            
        }

        private void NewProduct_CheckedChanged(object sender, EventArgs e)
        {
            Category.Visible = true;
            ProductName.Visible = true;
            Price.Visible = true;
            Stock.Visible = true;
            ExistProduct.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible= true;
            
        }

        private void AddExistProduct_CheckedChanged(object sender, EventArgs e)
        {
            Category.Visible = true;
            ProductName.Visible = false;
            Stock.Visible = true;
            ExistProduct.Visible = true;
            Price.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = false;


        }

        private void Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddExistProduct.Checked)
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
                                ExistProduct.Items.Add(item);
                            }
                        }
                    }
                    con.Close();
                }
            }
        }
    }
}

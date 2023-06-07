using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopV2
{
    public class Product
    {
        private string name;
        private double stock;
        private decimal price;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public Product(string name, double stock, decimal price)
        {
            Name = name;
            Stock = stock;
            Price = price;
        }
        public string Print()
        {
            return $"{this.Name} -> {stock.ToString()}x{price.ToString()} = {((decimal)(stock)*price).ToString()}";
        }
    }
}

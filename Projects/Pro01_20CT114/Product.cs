using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro01_20CT114
{
   public class Product
    {
        private string productName;
        private double price;
        private double discount=0;

        private string display; 
        public double Price {
            get { return price; }
            set { price = value; }    
        }
        public string ProductName { get => productName; set => productName = value; }
        public string Display
        {
            get { return string.Format("{0} - {1:#,###0} VND - {2}", productName, price,discount); }
        }

        public double Discount { get => discount; set => discount = value; }

        public Product()
        {
            this.productName = string.Empty;
            this.price = 0;
           

        }
        public Product(string productName,double price)
        {
            this.productName = productName;
            this.price = price;
        }
        public Product(string productName, double price,double discount)
        {
            this.productName = productName;
            this.price = price;
            this.discount = discount;
        }
    }
}

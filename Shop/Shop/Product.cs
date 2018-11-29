using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Product
    {
        //member fields
        public int id { get; set; }
        public string name { get; set; }
        public Origin origin{ get; set; }
        public Category category { get; set; }
        public double  price { get; set; }
        public int barcode { get; set; }

        //constructors
        public Product() { }

        public Product(int barcode)
        {
            this.barcode = barcode;
        }

        public Product(string name, int id, double price,Category category, Origin origin)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.origin = origin;
            this.category = category;
        }
    }
}

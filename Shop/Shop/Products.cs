using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Products
    {
        public List<Product> products { get; set; }

        public Products(List<Product> products)
        {
            this.products = products;
        }

        public bool addProduct(Product product) {
            Product prod = product;
            products.Add(prod);
            return products.Contains(prod);
        }

        public int getNumberOfProducts() {
            int num = 0;

            foreach (var x in products) {
                num++;
            }
            return num;
        }

        public Product sellItem(Product product) {

            Product temp = new Product();

            foreach (var item in products) {

                if (item.barcode == product.barcode) {
                    temp = item;
                }
            }
            products.Remove(temp);
            return temp;
        }
    }
}

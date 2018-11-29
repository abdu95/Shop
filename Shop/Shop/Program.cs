using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Products products = new Products(new List<Product>());

            products.addProduct(new Product("Xiaomi Note 3", 1, 200.0, new Category("mobile device"), new Origin("Xiaomi Co.","China")));

            products.addProduct(new Product("Blackberry", 2, 35.0, new Category("mobile device"), new Origin("Blackberry Co.", "Canada")));

            products.addProduct(new Product("Iphone 7", 3, 700.0, new Category("mobile device"), new Origin("Apple Co.", "USA")));

            products.products[0].barcode = 3322;
            

            Console.WriteLine("==================  PRODUCT COUNT  ===============");

            Console.WriteLine("Product count: " + products.getNumberOfProducts());

            Console.WriteLine("================== ALL PRODUCTS ===============");

            PrintAllProducts(products);

            Product productToSell = new Product();

            productToSell.barcode = 3322;

            Product productSold = products.sellItem(productToSell);

            Console.WriteLine("=================== PRODUCT SOLD ===============");

            Console.WriteLine("Sold product details: ");
            Console.WriteLine("ID: " + productSold.id);
            Console.WriteLine("NAME: " + productSold.name);

            Console.WriteLine("==================  PRODUCT COUNT  ===============");

            Console.WriteLine("Product count: " + products.getNumberOfProducts());

            Console.WriteLine("================== ALL PRODUCTS ===============");

            PrintAllProducts(products);
            Console.ReadKey();
        }

        static void PrintAllProducts(Products products) {

            foreach (var x in products.products) {
                Console.WriteLine("Product: " + x.name);
                Console.WriteLine("Price: " + x.price);
                Console.WriteLine("Category: " + x.category.categoryName);
                Console.WriteLine("Company: " + x.origin.company);
                Console.WriteLine("Country: " + x.origin.country);
                Console.WriteLine();
            }
        }
    }
}

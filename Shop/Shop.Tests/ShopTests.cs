using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Shop.Tests
{
    [TestClass]
    public class ShopTests
    {
        [TestMethod]
        public void AddProduct_WhenNewProductAdded_ReturnTrue()
        {
            Products products = new Products(new List<Product>());

            var expected = true;

            var actual = products.addProduct(new Product());

            Assert.AreEqual(expected, actual); 

        }
        [TestMethod]
        public void GetProduct_WhenNewProductAdded_Return1()
        {
            Products products = new Products(new List<Product>());

            var expected = 1;
            products.addProduct(new Product());
            var actual = products.getNumberOfProducts();

            Assert.AreEqual(expected, actual);

        }
    }
}

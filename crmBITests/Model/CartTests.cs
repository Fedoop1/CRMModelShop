using Microsoft.VisualStudio.TestTools.UnitTesting;
using crmBI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crmBI.Model.Tests
{
    [TestClass()]
    public class CartTests
    {
        [TestMethod()]
        public void CartTest()
        {
            //Arrange
            Customer customer = new Customer() { Name = "test1", CustomerId = 1 };
            Product product1 = new Product() { Name = "pr1", Count = 1, Price = 1, ProductId = 1 };
            Product product2 = new Product() { Name = "pr2", Count = 1, Price = 1, ProductId = 2 };
            Cart cart = new Cart(customer);
            List<Product> expectedList = new List<Product>() { product1, product1, product2 };
            //Act
            cart.Add(product1);
            cart.Add(product1);
            cart.Add(product2);
            List<Product> cartList = cart.GetProducts();
            //Assert
            Assert.AreEqual(expectedList.Count, cartList.Count);
        }

    }
}
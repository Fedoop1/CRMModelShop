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
    public class CashDeskTests
    {
        [TestMethod()]
        public void CashDeskTest()
        {
            //Arrange
            Customer customer1 = new Customer() { Name = "test1", CustomerId = 1 };
            Customer customer2 = new Customer() { Name = "test2", CustomerId = 2 };
            Product product1 = new Product() { Name = "pr1", Count = 10, Price = 1, ProductId = 1 };
            Product product2 = new Product() { Name = "pr2", Count = 10, Price = 2, ProductId = 2 };
            Cart cart1 = new Cart(customer1);
            Cart cart2 = new Cart(customer2);
            Seller seller = new Seller() { Name = "seller1", SellerId = 1 };
            CashDesk cashDesk = new CashDesk(seller, 1);
            cashDesk.maxLenght = 10;
            cashDesk.isModel = true;
            //Act
            cart1.Add(product1);
            cart1.Add(product1);
            cart1.Add(product2);

            cart2.Add(product2);
            cart2.Add(product2);
            cart2.Add(product1);

            cashDesk.Add(cart1);
            cashDesk.Add(cart2);

            decimal result1 = cashDesk.Dequeue();
            decimal result2 = cashDesk.Dequeue();

            //Assert
            Assert.AreEqual(4, result1);
            Assert.AreEqual(5, result2);
            Assert.AreEqual(7, product1.Count);
            Assert.AreEqual(7, product2.Count);
        }

        
    }
}
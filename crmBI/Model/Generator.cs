using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crmBI.Model
{
    class Generator
    {
        List<Customer> Customers = new List<Customer>();

        List<Seller> Sellers = new List<Seller>();

        List<Product> Products = new List<Product>();

        Random rnd = new Random();

        public List<Customer> GenNewCustomers(int count)
        {
            List<Customer> result = new List<Customer>();

            for (int iterration = 0; iterration < count; iterration++)
            {
                var customer = new Customer() { CustomerId = Sellers.Count, Name = GetRandomText() };
                result.Add(customer);
                Customers.Add(customer);
            }

            return result;
        }
        public List<Seller> GenNewSellers(int count)
        {
            List<Seller> result = new List<Seller>();

            for (int iterration = 0; iterration < count; iterration++)
            {
                var seller = new Seller() { Name = GetRandomText(), SellerId = Sellers.Count};
                result.Add(seller);
                Sellers.Add(seller);
            }

            return result;
        }
        public List<Product> GenNewProducts(int count)
        {
            List<Product> result = new List<Product>();

            for (int iterration = 0; iterration < count; iterration++)
            {
                var product = new Product() { Name = GetRandomText(), Count = rnd.Next(10,1000), Price = Math.Round(Convert.ToDecimal(rnd.Next(1, 15) + rnd.NextDouble()), 2), ProductId = Products.Count};
                result.Add(product);
                Products.Add(product);
            }

            return result;
        }

        public List<Product> GetRandomProducts(int countMin, int countMax)
        {
            List<Product> result = new List<Product>();
            int count = rnd.Next(countMin, countMax);
            for (int iterration = 0; iterration < count; iterration++)
            {
                result.Add(Products[rnd.Next(Products.Count - 1)]);
            }

            return result;
        }

        public List<Customer> GetRandomCustomers(int countMin, int countMax)
        {
            List<Customer> result = new List<Customer>();
            int count = rnd.Next(countMin, countMax);
            for (int iterration = 0; iterration < count; iterration++)
            {
                result.Add(Customers[rnd.Next(Customers.Count - 1)]);
            }

            return result;
        }


        private string GetRandomText()
        {
            return Guid.NewGuid().ToString().Substring(1, 5);
        }
    }
}

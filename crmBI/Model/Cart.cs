using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crmBI.Model
{
    public class Cart : IEnumerable
    {
        private Customer Customer;

        private Dictionary<Product, int> products = new Dictionary<Product, int>();
        public Cart(Customer customer)
        {
            this.Customer = customer;
        }

        public void Add(Product product)
        {
            if(products.TryGetValue(product, out int count))
            {
                products[product] = ++count;
                return;
            }

            products.Add(product, 1);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var product in products.Keys)
            {
                for (int index = 0; index < products[product]; index++)
                {
                    yield return product;
                }
            }
        }
        public List<Product> GetProducts()
        {
            List<Product> productList = new List<Product>();
            foreach (Product product in this)
            {
                productList.Add(product);
            }

            return productList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crmBI.Model
{
    public class ShopComputerModel
    {
        Generator Generator = new Generator();

        Queue<Cart> Carts = new Queue<Cart>();

        List<Sell> Sells = new List<Sell>();

        List<Bill> Bills = new List<Bill>();

        List<CashDesk> CashDesks = new List<CashDesk>();

        Queue<Seller> Sellers = new Queue<Seller>();

        Random rnd = new Random();

        public ShopComputerModel()
        {
            var sellers = Generator.GenNewSellers(20);
            var products = Generator.GenNewProducts(1000);
            var customers = Generator.GenNewCustomers(100);

            foreach (var seller in sellers)
            {
                Sellers.Enqueue(seller);
            }

            for (int cashDesk = 0; cashDesk < 3; cashDesk++)
            {
                CashDesks.Add(new CashDesk(Sellers.Dequeue(), CashDesks.Count) { isModel = true, maxLenght = 20 });
            }
        }

        public void Start()
        {
            var customers = Generator.GetRandomCustomers(10, 15);
            var carts = new List<Cart>();

            foreach (var customer in customers)
            {
                Cart cart = new Cart(customer);

                foreach (var product in Generator.GetRandomProducts(1, 10))
                {
                    cart.Add(product);
                }

                carts.Add(cart);
            }

            while(carts.Count > 0)
            {
                CashDesk desk = CashDesks[rnd.Next(CashDesks.Count - 1)];
                desk.Add(carts[0]);
                carts.RemoveAt(0);
            }

            while(CashDesks.Any(x=> x.Count > 0))
            {
                var desk = CashDesks[rnd.Next(CashDesks.Count - 1)];
                desk.Dequeue();
            }

        }


    }
}

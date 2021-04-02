using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace crmBI.Model
{
    public class ShopComputerModel
    {
        Generator Generator = new Generator();

        List<Cart> Carts = new List<Cart>();

        List<Sell> Sells = new List<Sell>();

        List<Bill> Bills = new List<Bill>();

        public List<CashDesk> CashDesks = new List<CashDesk>();

        Queue<Seller> Sellers = new Queue<Seller>();

        Random rnd = new Random();

        public int customerSpeed = 1000;
        public int sellerSpeed = 1000;

        bool isWorking = true;

        public ShopComputerModel()
        {
            var sellers = Generator.GenNewSellers(20);
            Generator.GenNewProducts(1000);
            Generator.GenNewCustomers(1000);

            foreach (var seller in sellers)
            {
                Sellers.Enqueue(seller);
            }

            for (int cashDesk = 0; cashDesk < 3; cashDesk++)
            {
                CashDesks.Add(new CashDesk(Sellers.Dequeue(), CashDesks.Count, null) { isModel = true, maxLenght = 20 });
            }
        }

        public void Start()
        {
            isWorking = true;
            Task.Run(() => CreateCart(15, customerSpeed));
            var deskTasks = CashDesks.Select(c => new Task(() => CashDeskWork(c, sellerSpeed)));

            foreach (var task in deskTasks)
            {
                task.Start();
            }
        }

        private void CreateCart(int customerCount, int sleep)
        {
            while(isWorking)
            {
                var customers = Generator.GenNewCustomers(customerCount);

                foreach (var customer in customers)
                {
                    Cart newCart = new Cart(customer);

                    foreach (Product product in Generator.GetRandomProducts(10, 30))
                    {
                        newCart.Add(product);
                    }

                    CashDesk cash = CashDesks[rnd.Next(CashDesks.Count)];
                    cash.Enqueue(newCart);
                }

                Thread.Sleep(sleep);
            }
        }

        public void Stop()
        {
            isWorking = false;
        }

        private void CashDeskWork(CashDesk desk, int sleep)
        {
            while(isWorking)
            {
                if (desk.Count > 0)
                {
                    desk.Dequeue();
                    Thread.Sleep(sleep);
                }
            }
        }


    }
}

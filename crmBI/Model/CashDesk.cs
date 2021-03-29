﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crmBI.Model
{
    public class CashDesk
    {
        Seller seller;
        public int number;
        public int maxLenght;
        Queue<Cart> queue = new Queue<Cart>();
        public bool isModel;
        public int exitCount = 0;
        CrmContext db = new CrmContext();
        public int Count => queue.Count;
        public event EventHandler<Bill> BillOut;

        public CashDesk(Seller seller, int number)
        {
            this.seller = seller;
            this.number = number;
        }
        public void Enqueue(Cart cart)
        {
            if (queue.Count < maxLenght)
            {
                queue.Enqueue(cart);
                return;
            }

            exitCount++;
            
        }
        public decimal Dequeue()
        {
            decimal sum = 0;

            if (queue.Count == 0) { return sum; }

            Cart cart = queue.Dequeue();
            

            if (cart != null)
            {
                Bill bill = new Bill
                {
                    Customer = cart.Customer,
                    Date = DateTime.Now,
                    Seller = this.seller,
                    CustomerId = cart.Customer.CustomerId,
                    SellerId = seller.SellerId,
                    Price = sum
                };

                if (!isModel)
                {
                    db.Bills.Add(bill);
                    db.SaveChanges();
                }


                List<Sell> sells = new List<Sell>();

                foreach (Product product in cart)
                {
                    if (product.Count > 1)
                    {
                        Sell sell = new Sell() { Product = product, ProductId = product.ProductId, Bill = bill, BillId = bill.BillId };
                        product.Count--;
                        sum += product.Price;
                        sells.Add(sell);
                    }
                }

                bill.Price = sum;

                if(!isModel)
                {
                    db.Sells.AddRange(sells);
                    db.SaveChanges();
                }

                BillOut?.Invoke(this, bill);
            }

            return sum;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace crmBI.Model
{
    public class CrmContext : DbContext
    {
        public CrmContext() : base("CrmConnection") { }

        public DbSet<Bill> Bills { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Sell> Sells { get; set; }
    }
}

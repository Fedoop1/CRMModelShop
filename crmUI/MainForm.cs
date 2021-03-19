using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using crmBI;
using crmBI.Model;

namespace crmUI
{
    public partial class MainForm : Form
    {
        private CrmContext database;
        public MainForm()
        {
            InitializeComponent();
            database = new CrmContext();
        }

        private void ProductMenu_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog<Product>(database.Products);
            catalogProduct.Show();
        }

        private void SellerMenu_Click(object sender, EventArgs e)
        {
            var catalogSeller = new Catalog<Seller>(database.Sellers);
            catalogSeller.Show();
        }

        private void CustomerMenu_Click(object sender, EventArgs e)
        {
            var catalogCustomer = new Catalog<Customer>(database.Customers);
            catalogCustomer.Show();
        }

        private void BillMenu_Click(object sender, EventArgs e)
        {
            var catalogBill = new Catalog<Bill>(database.Bills);
            catalogBill.Show();
        }

        private void CustomerAddMenu_Click(object sender, EventArgs e)
        {
            var customerForm = new CustomerForm();

            if(customerForm.ShowDialog() == DialogResult.OK)
            {
                database.Customers.Add(customerForm.customer);
                database.SaveChanges();
            }
        }

        private void SellerAddMenu_Click(object sender, EventArgs e)
        {
            //var SellerForm = new SellerForm;

            //if (SellerForm.ShowDialog() == DialogResult.OK)
            //{
            //    database.Sellers.Add(SellerForm);
            //    database.SaveChanges();
            //}
        }
    }
}

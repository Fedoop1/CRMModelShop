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
            var catalogProduct = new Catalog<Product>(database.Products, database);
            catalogProduct.Show();
        }

        private void SellerMenu_Click(object sender, EventArgs e)
        {
            var catalogSeller = new Catalog<Seller>(database.Sellers, database);
            catalogSeller.Show();
        }

        private void CustomerMenu_Click(object sender, EventArgs e)
        {
            var catalogCustomer = new Catalog<Customer>(database.Customers, database);
            catalogCustomer.Show();
        }

        private void BillMenu_Click(object sender, EventArgs e)
        {
            var catalogBill = new Catalog<Bill>(database.Bills, database);
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
            var SellerForm = new SellerForm();

            if (SellerForm.ShowDialog() == DialogResult.OK)
            {
                database.Sellers.Add(SellerForm.seller);
                database.SaveChanges();
            }
        }

        private void ProductAddMenu_Click(object sender, EventArgs e)
        {
            var ProductForm = new ProductForm();

            if (ProductForm.ShowDialog() == DialogResult.OK)
            {
                database.Products.Add(ProductForm.product);
                database.SaveChanges();
            }
        }

        private void ModelMenuItem_Click(object sender, EventArgs e)
        {
            var ModelForm = new ModelForm();
            ModelForm.Show();
        }
    }
}
